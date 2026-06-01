using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administration_RRHH.Domain;

namespace Administration_RRHH.Services.BussinesLogic
{
    internal class EmployeeBussines
    {
        Employee employee;

        public EmployeeBussines()
        {
            employee = new Employee();
        }

        public int InsertEmployee()
        {
            if (employee.AddEmployee() > 0)
                return 1; // Error al agregar el empleado
            else
                return 0;
        }

        public Employee ReadEmployee (string idNumber)
        {
            return new Employee();
        }

        public List<Employee> ListEmployees()
        {
            return new List<Employee>();
        }

        public int UpdateEmployee(string idNumber)
        {
            return new Employee();
        }
    }
}
