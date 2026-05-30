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
        /* Propiedades Auto-implementadas                   */
        /* --------------------------------------------------------------------- */
        public string IdentityCard { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string MaritalStatus { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        /* --------------------------------------------------------------------- */
        /* Propiedades con Validación                       */
        /* --------------------------------------------------------------------- */
        private DateOnly _birthDate;
        public DateOnly BirthDate
        {
            get => _birthDate;
            set
            {
                var today = DateOnly.FromDateTime(DateTime.Today);
                if (value > today)
                    throw new ArgumentException("Error en dato fecha de nacimiento.");
                _birthDate = value;
            }
        }

        private int _numberChildren;
        public int NumberChildren
        {
            get => _numberChildren;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error en dato número de hijos.");
                _numberChildren = value;
            }
        }

        /* --------------------------------------------------------------------- */
        /* Constructores                            */
        /* --------------------------------------------------------------------- */
        public Employee() { }

        public Employee(string identityCard, string name, string surname, string address,
                        DateOnly birthDate, string maritalStatus, int numberChildren,
                        string email, string phone)
        {
            IdentityCard = identityCard;
            Name = name;
            Surname = surname;
            Address = address;
            BirthDate = birthDate;
            MaritalStatus = maritalStatus;
            NumberChildren = numberChildren;
            Email = email;
            Phone = phone;
        }

        /* --------------------------------------------------------------------- */
        /* Métodos CRUD (Idealmente deben moverse a EmployeeRepository)        */
        /* --------------------------------------------------------------------- */
        public bool AddEmployee() => throw new NotImplementedException("Implementar conexión a SQL Server aquí o en la capa de Datos.");
        public Employee? ReadEmployee(string cedula) => throw new NotImplementedException();
        public static List<Employee> ListEmployee() => throw new NotImplementedException();
        public bool UpdateEmployee(string filtro) => throw new NotImplementedException();
        public bool TerminateEmployee(string filtro) => throw new NotImplementedException();
    }//end-class
}//end-namespace.