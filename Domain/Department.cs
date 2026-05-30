using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Administration_RRHH.Domain
{
    public class Department
    {
        /* ----------------------------------------------------------- */
        /* Propiedades                                                 */
        /* ----------------------------------------------------------- */
        private string _departmentCode = "DPT-";
        public string DepartmentCode
        {
            get => _departmentCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Valor del código del Departamento no puede estar vacío");
                _departmentCode = value;
            }
        }

        public string DepartmentName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        /* ----------------------------------------------------------- */
        /* Constructores                                               */
        /* ----------------------------------------------------------- */
        public Department() { }

        public Department(string departmentName, string description, string departmentCode)
        {
            DepartmentCode = departmentCode;
            DepartmentName = departmentName;
            Description = description;
        }

        /* ----------------------------------------------------------- */
        /* Métodos                                                     */
        /* ----------------------------------------------------------- */
        public List<Department> ReadAllDepartments() => new List<Department>();
        public int AddDepartment() => 1;
        public Department ReadDepartment(string code) => new Department();
        public bool UpdateDepartment() => true;
        public bool DeleteDepartment(string code) => true;


    }//End of class
}//End of namespace