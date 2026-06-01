using Administration_RRHH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Domain
{
    public class FamilyReference:Individual
    {
        /* ---------------------------------------------------------------- */
        /* Declaracion de Propiedades de la Clase FamilyReference       */
        /* -----------------------------------------------------------------*/

        public long FamilyReferenceId { get; set; }
        public long EmployeeFileId { get; set; }
        public string IdentityCard { get; set; }
        public string Names { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Enabled { get; set; }

        /* ---------------------------------------------------------------- */
        /* Declaracion de Constructores de la clase FamilyReference     */
        /* -----------------------------------------------------------------*/

        public FamilyReference()
        {
            FamilyReferenceId = 0;
            this.EmployeeFileId = 0;
            this.IdentityCard = string.Empty;
            this.Names = string.Empty;
            this.LastName = string.Empty;
            this.BirthDate = DateTime.Now.Date; // Inicialización segura
            this.Gender = string.Empty;
            this.Relationship = string.Empty;
            this.PhoneNumber = string.Empty;
            this.Address = string.Empty;
            this.Enabled = true;
        }

        public FamilyReference(long familyReferenceId, long employeeFileId, string identityCard, string names, string lastName, DateTime birthDate, string gender, string relationship, string phoneNumber, string address, bool enabled)
        {
            this.FamilyReferenceId = familyReferenceId;
            this.EmployeeFileId = employeeFileId;
            this.IdentityCard = identityCard;
            this.Names = names;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Relationship = relationship;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Enabled = enabled;
        }

        /* ---------------------------------------------------------------- */
        /* Declaracion de Métodos de la clase FamilyReference           */
        /* -----------------------------------------------------------------*/

        public long AddFamilyReference()
        {
            return 0;
        }

        public FamilyReference GetFamilyReferenceById(long referenceId)
        {
            return new FamilyReference();
        }

        public List<FamilyReference> ListFamilyReferences()
        {
            return new List<FamilyReference>();
        }

        public void ModifyFamilyReference(long referenceId)
        {
        }

        public bool InabilityFamilyReference()
        {
            return true;
        }
    }
}
