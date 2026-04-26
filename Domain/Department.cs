using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Administration_RRHH.Domain
{
    public class Department
    {
        /* ----------------------------------------------------------- */
        /* Campos / atributos                                         */
        /* ----------------------------------------------------------- */
        private string _departmentCode; // Prefijo para el código del departamento
        private string _departmentName;
        private string _description;
        private bool _isActive;

        /* ----------------------------------------------------------- */
        /* Propiedades                                                 */
        /* ----------------------------------------------------------- */

        public string DepartmentCode
        {
            get { return _departmentCode; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Valor del código del Departamento no puede estar vacío");
                }//end-if
                _departmentCode = value;
            }//end-set
        }//end-DepartmentCode

        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }//end-DepartmentName

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }//end-Description

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }//end-IsActive

        /* ----------------------------------------------------------- */
        /* Constructores                                               */
        /* ----------------------------------------------------------- */

        // Constructor sin parámetros
        public Department()
        {
            _departmentCode = "DPT-";
            _departmentName = string.Empty;
            _description = string.Empty;
            _isActive = true; // Por defecto activo
        }

        // Constructor con parámetros
        public Department(string departmentName, string description, string departmentCode)
        {
            _departmentCode = departmentCode;
            _departmentName = departmentName;
            _description = description;
            _isActive = true;
        }

        /* ----------------------------------------------------------- */
        /* Métodos                                                     */
        /* ----------------------------------------------------------- */

        public List<Department> ReadAllDepartments()
        {
            List<Department> lstEmployee = new List<Department>();

            lstEmployee.Add(new Department("Recursos Humanos",
                "Departamento encargado de la gestión del talento humano",
                "DPT-001"));

            lstEmployee.Add(new Department("Finanzas",
                "Departamento encargado de la gestión financiera",
                "DPT-002"));

            lstEmployee.Add(new Department("Tecnología",
                "Departamento encargado de la gestión tecnológica",
                "DPT-003"));

            return lstEmployee;
        }

        public int AddDepartment()
        {
            List<Department> lstEmployee = new List<Department>();

            lstEmployee.Add(this);

            if (lstEmployee.Count > 0)
                return lstEmployee.Count;

            return 0;
        }

        public Department ReadDepartment(string code)
        {
            List<Department> lstEmployee = new List<Department>();

            lstEmployee.Add(new Department("Recursos Humanos",
                "Departamento encargado de la gestión del talento humano",
                "DPT-001"));

            lstEmployee.Add(new Department("Finanzas",
                "Departamento encargado de la gestión financiera",
                "DPT-002"));

            lstEmployee.Add(new Department("Tecnología",
                "Departamento encargado de la gestión tecnológica",
                "DPT-003"));

            var department = lstEmployee.FirstOrDefault(d => d.DepartmentCode == code);

            if (department == null)
                throw new KeyNotFoundException("Referencia vacía o nula de un elemento departamento");

            return department;
        }

        public bool UpdateDepartment()
        {
            // Pendiente de implementación real
            return true;
        }

        public bool DeleteDepartment(string code)
        {
            List<Department> lstEmployee = new List<Department>();

            lstEmployee.Add(new Department("Recursos Humanos",
                "Departamento encargado de la gestión del talento humano",
                "DPT-001"));

            lstEmployee.Add(new Department("Finanzas",
                "Departamento encargado de la gestión financiera",
                "DPT-002"));

            lstEmployee.Add(new Department("Tecnología",
                "Departamento encargado de la gestión tecnológica",
                "DPT-003"));

            var department = lstEmployee.FirstOrDefault(d => d.DepartmentCode == code);

            if (department != null)
            {
                department.IsActive = false; // Eliminación lógica
            }

            return true;
        }

    }//End of class
}//End of namespace