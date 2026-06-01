using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using Administration_RRHH.Models;

namespace Administration_RRHH.Domain
{
    public class Employee:Individual
    {

        /* --------------------------------------------------------------------- */
        /* Propiedades Auto-implementadas                   */
        /* --------------------------------------------------------------------- */
        public string IdentityCard { get; set; }
        public string Name { get; set; } 
        public string Surname { get; set; }
        public string MaritalStatus { get; set; }
        public string Inss { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; } 
        public int NumberChildren { get; set; } 
        public bool IsActive { get; set; }

        
        /* --------------------------------------------------------------------- */
        /* Constructores                            */
        /* --------------------------------------------------------------------- */
        public Employee() { }

        public Employee( string inns, bool isActive, int numberChildren, string email, string address, string phone, string surname, string name, DateOnly birthDate, string maritalStatus) : base(IdentityCard,)
        {
            Inss = inns;
            IsActive = isActive;
            NumberChildren = numberChildren;
            Email = email;
        }

        /* --------------------------------------------------------------------- */
        /* Métodos CRUD (Idealmente deben moverse a EmployeeRepository)        */
        /* --------------------------------------------------------------------- */

        public override bool ValidateBirthDate()
        {
            // Validar que la fecha de nacimiento no sea en el futuro
                if (BirthDate > DateOnly.FromDateTime(DateTime.Today))
                {
                    return false; // La fecha de nacimiento no puede ser en el futuro
                }
                return true; // La fecha de nacimiento es válida
        }

        public int AddEmployee()
        {
            return 0;
        }

        /// <summary>
        /// Lee el registro de un empleado a través de su número de identificación y devuelve un objeto Employee con los datos correspondientes.
        /// </summary>
        /// <param name="idNumber"></param>
        /// <returns></returns> Empleado con los datos correspondientes al número de identificación proporcionado.
        public Employee GetEmployeeById(int idNumber)
        {
            return new Employee();
        }

        /// <summary>
        /// Lista un set de Empleados, segmentados por bloques de paginacion 10 en 10
        /// </summary>
        /// <returns></returns> Listaod de empleados ordenados de forma desecndente por fecha de ingreso </returns>

        public List<Employee> ListEmployees()
        {
            return new List<Employee>(); // Pendiente de Implementacion con la base de datos
        }

        /// <summary>
        /// Modifica el registro de un empleado especificado por su numero de cedula.
        /// El metodo recibe el numero de cedula del empleado a modificar y los nuevos datos del empleado.
        /// </summary>
        /// <param name="idNumber"></param>
        public void ModifyEmployee (string idNumber)
        {
            // Pendiente de Implementacion con la base de datos
        }

        /// <summary>
        /// Desabilita 
        /// </summary>
        /// <param name="idNumber"></param>
         public void DisableEmployee(string idNumber)
        {
            // Pendiente de Implementacion con la base de datos
        }
    }//end-class
}//end-namespace.