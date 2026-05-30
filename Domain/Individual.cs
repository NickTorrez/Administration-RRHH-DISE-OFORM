using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Models
{
    public abstract class Individual //Puede ser empleado, cliente, proveedor, etc.
    {
        /* ---------------------------------------------------------------------------------*/
        /*                                                                                  */
        /* ---------------------------------------------------------------------------------*/

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        /*---------------------------------------------------------------------------------*/
        /*                                                                                  */
        /*---------------------------------------------------------------------------------*/

        public Individual()
        {
            this.Id = 0;
            this.Name = string.Empty;
            this.Surname = string.Empty;
            this.BirthDate = DateOnly.MinValue;
            this.Email = string.Empty;
            this.Phone = string.Empty;
            this.Address = string.Empty;
        }

        public Individual(int id, string name, string surname, DateOnly birthDate, string email, string phone, string address)
        {
            Id = id;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
            Address = address;
        }

        /*---------------------------------------------------------------------------------*/
        /*                                                                                  */
        /* ---------------------------------------------------------------------------------*/

        public int CalculateAge()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            int age = today.Year - BirthDate.Year;
            if (BirthDate > today.AddYears(-age))
            {
                age--;
            }
                
            return age;
        }

        public abstract bool ValidateBirthDate();
    }
}
