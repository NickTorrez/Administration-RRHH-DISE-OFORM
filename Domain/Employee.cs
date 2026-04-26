using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq; 

namespace Administration_RRHH.Domain
{
    public class Employee
    {
        /* --------------------------------------------------------------------- */
        /*                      Campos / Atributos                               */                
        /* --------------------------------------------------------------------- */
        private string _identityCard;
        private string _name;
        private string _surname;
        private System.DateOnly _birthDate;
        private string _maritalStatus;
        private int _numberChildren;        
        private string _phone;
        private string _email;
        private string _address;
        private bool _isActive;

        /* --------------------------------------------------------------------- */
        /*                      Constructores                                    */
        /* --------------------------------------------------------------------- */
        // Constructor por defecto
        public Employee()
        {
            _identityCard = string.Empty;
            _name = string.Empty;
            _surname = string.Empty;            
            _birthDate = default;
            _maritalStatus = string.Empty;
            _numberChildren = 0;            
            _phone = string.Empty;
            _email = string.Empty;
            _address = string.Empty;
            _isActive = true;
        }//end-constructor

        // Constructor con parámetros
        public Employee(string identityCard, string name, string surname, string address, 
                        System.DateOnly birthDate,string maritalStatus, int numberChildren, 
                        string email, string phone)
        {
            _identityCard = identityCard;
            _name = name;
            _surname = surname;
            _address = address;
            _birthDate = birthDate;
            _maritalStatus = maritalStatus;
            _numberChildren = numberChildren;
            _email = email;
            _phone = phone;
            _isActive = true; // Por defecto, el empleado se considera activo al ser creado
        }//end-constructor

        /* --------------------------------------------------------------------- */
        /*                      Propiedades                                      */
        /* --------------------------------------------------------------------- */
        public string IdentityCard
        {
            get{ return _identityCard; } 
            set{ _identityCard = value; } 
        }//end-IdentityCard
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end-Name

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }//end-Surname

        public System.DateOnly BirthDate
        {
            get { return _birthDate; }
            set
            {   // Validar que la fecha de nacimiento no sea mayor a la fecha actual
                var today = System.DateOnly.FromDateTime(System.DateTime.Today);
                if (value > today)
                    throw new ArgumentException("Error en dato fecha de nacimiento.");
                //Si la fecha es correcta
                _birthDate = value;
            }
        }//end-BirthDate

        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }//end-MaritalStatus

        public int NumberChildren
        {
            get { return _numberChildren; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error en dato número de hijos.");
                _numberChildren = value; //Asignar valor si es mayor que 0
            }
        }//end-NumberChildren

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }//end-Phone

        public string Email
        {
            get { return _email; }
            set { _email = value; }

        }//end-Email

        public string Address
        {
            get {return _address; } 
            set { _address = value;}             
        }//end-Address

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }//end-IsActive

        /* --------------------------------------------------------------------- */
        /*                      Métodos                                          */
        /* --------------------------------------------------------------------- */
        public bool AddEmployee()
        {
            string filePath; // Ruta del archivo JSON
            // Obtener la ruta del directorio base del proyecto
            try
            {
                var baseDirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                // Subir 3 niveles de forma segura (equivalente a GetParent(...).Parent.Parent)
                var projectRoot = baseDirInfo.Parent?.Parent?.Parent;
                if (projectRoot == null)
                    throw new Exception("No se pudo determinar la ruta base del proyecto.");

                string basePath = projectRoot.FullName;
                string dataFolder = Path.Combine(basePath, "Data"); // Carpeta para almacenar los datos
                string updateJson;

                // Crear la carpeta "Data" si no existe
                if (!Directory.Exists(dataFolder))
                {
                    Directory.CreateDirectory(dataFolder);
                }

                filePath = Path.Combine(dataFolder, "employees.json"); // Ruta completa del archivo JSON

                //Preparar la escritura del nuevo empleado al archivo JSON
                List<Employee> employees = new List<Employee>(); // Lista para almacenar los empleados existentes

                //Leer el archivo JSON si existe para obtener la lista actual de empleados
                if (File.Exists(filePath))
                {
                    // Leer el contenido del archivo JSON y deserializarlo a la lista de empleados
                    string jsonData = File.ReadAllText(filePath);
                    if (!string.IsNullOrEmpty(jsonData))
                    {
                        // Deserializar el JSON a una lista de empleados
                        employees = JsonSerializer.Deserialize<List<Employee>>(jsonData) ?? new List<Employee>();
                    }//end-if
                }//end-if
                else
                {
                    // Si el archivo no existe, inicializar una nueva lista de empleados
                    employees = new List<Employee>();
                }//end-else

                employees.Add(this); // Agregar el nuevo empleado a la lista
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true // Opciones para formatear el JSON                                     
                };

                updateJson = JsonSerializer.Serialize(employees, options); // Serializar la lista de empleados a JSON

                File.WriteAllText(filePath, updateJson); // Escribir el JSON actualizado en el archivo
            }
            catch (Exception ex)
            {
               throw new Exception($"Error al agregar el empleado: {ex.Message}");
            }//end-try-catch

            return true;
        }//End AddEmployee

        public Employee? ReadEmployee(string cedula)
        {
            try
            {
                var baseDirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                var projectRoot = baseDirInfo.Parent?.Parent?.Parent;
                if (projectRoot == null)
                    throw new Exception("No se pudo determinar la ruta base del proyecto.");

                string dataFolder = Path.Combine(projectRoot.FullName, "Data");
                string filePath = Path.Combine(dataFolder, "employees.json");

                if (!File.Exists(filePath))
                    return null; // o lanzar una excepción para indicar que el archivo no existe

                string jsonData = File.ReadAllText(filePath);
                if (string.IsNullOrEmpty(jsonData))
                    return null;

                var employees = JsonSerializer.Deserialize<List<Employee>>(jsonData) ?? new List<Employee>();
                return employees.FirstOrDefault(e => e.IdentityCard == cedula);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer el empleado: {ex.Message}");
            }
        }//end-ReadEmployee

        public static List<Employee> ListEmployee()
        {
            try
            {
                var baseDirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                var projectRoot = baseDirInfo.Parent?.Parent?.Parent;
                if (projectRoot == null)
                    throw new Exception("No se pudo determinar la ruta base del proyecto.");

                string dataFolder = Path.Combine(projectRoot.FullName, "Data");
                string filePath = Path.Combine(dataFolder, "employees.json");

                if (!File.Exists(filePath))
                    return new List<Employee>();

                string jsonData = File.ReadAllText(filePath);
                if (string.IsNullOrEmpty(jsonData))
                    return new List<Employee>();

                var employees = JsonSerializer.Deserialize<List<Employee>>(jsonData) ?? new List<Employee>();
                return employees;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al listar los empleados: {ex.Message}");
            }
        }

        
        public bool UpdateEmployee(string filtro)
        {
            try
            {
                var baseDirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                var projectRoot = baseDirInfo.Parent?.Parent?.Parent;
                if (projectRoot == null)
                    throw new Exception("No se puede determinar la ruta base del sistema.");

                string dataFolder = Path.Combine(projectRoot.FullName, "Data");
                string filePath = Path.Combine(dataFolder, "employee.json");

                if (File.Exists(filePath))
                    return false;

                string jsonData = File.ReadAllText(filePath);
                if (string.IsNullOrEmpty(jsonData))
                    return false;

                var employees = JsonSerializer.Deserialize<List<Employee>>(jsonData) ?? new List<Employee>();

                int index = employees.FindIndex(e => e.IdentityCard == filtro);
                if (index == -1)
                    return false; //No se enocntro el empleado  a actualizar

                //Reemplazar el empleado econtrado por la instancia actual
                employees[index] = this;

                var options = new JsonSerializerOptions {WriteIndented = true};
                string updateJson = JsonSerializer.Serialize(employees, options);
                File.WriteAllText(filePath, updateJson);

                return true;


            }
            catch(Exception ex)
            {
                throw new Exception($"Error al actualizar el empleado: {ex.Message}");
            }
               
           
            throw new System.NotImplementedException();
        }
        public bool TerminateEmployee(string filtro)
        {
            try
            {
                var baseDirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                var projectRoot = baseDirInfo.Parent?.Parent?.Parent;
                if (projectRoot == null)
                    throw new Exception("No se pudo determinar la ruta base del sistema.");

                string dataFolder = Path.Combine(projectRoot.FullName, "Data");
                string filePath = Path.Combine(dataFolder, "employee.json");

                if(!File.Exists(filePath))
                    return false;

                string jsonData = File.ReadAllText(filePath);
                if(string.IsNullOrEmpty(jsonData)) 
                    return false;
                    
                var employees = JsonSerializer.Deserialize<List<Employee>>(jsonData) ?? new List<Employee>();

                int removedCount = employees.RemoveAll(e => e.IdentityCard == filtro);
                if (removedCount == 0)
                    return false; //No se encontro el empleado a eliminar

                var options = new JsonSerializerOptions { WriteIndented = true };
                string updateJson = JsonSerializer.Serialize(employees, options);
                File.WriteAllText(filePath, updateJson);

                return true;
            }
            catch(Exception ex) 
            {
                throw new Exception($"Error al eliminar el ampliado: {ex.Message}");
            }
            
        }


    }//end-class
}//end-namespace.