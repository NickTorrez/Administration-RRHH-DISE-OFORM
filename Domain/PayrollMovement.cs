using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Domain
{
    public class PayrollMovement
    {
        /* ---------------------------------------------------------------- */
        /* Declaracion de Propiedades de la Clase PayrollMovement       */
        /* -----------------------------------------------------------------*/

        public long PayrollId { get; set; }
        public long LaborContractId { get; set; }
        public int PayrollTypeId { get; set; }
        public string PayrollNumber { get; set; }
        public decimal BasicSalary { get; set; }
        public short Month { get; set; }
        public short FortnightNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public bool Enabled { get; set; }

        /* ---------------------------------------------------------------- */
        /* Declaracion de Constructores de la clase PayrollMovement     */
        /* -----------------------------------------------------------------*/

        public PayrollMovement()
        {
            this.PayrollId = 0;
            this.LaborContractId = 0;
            this.PayrollTypeId = 0;
            this.PayrollNumber = string.Empty;
            this.BasicSalary = 0.0m;
            this.Month = (short)DateTime.Now.Month;
            this.FortnightNumber = 1;
            this.IssueDate = DateTime.Now.Date;
            this.Enabled = true;
        }

        public PayrollMovement(long payrollId, long laborContractId, int payrollTypeId, string payrollNumber, decimal basicSalary, short month, short fortnightNumber, DateTime issueDate, bool enabled)
        {
            this.PayrollId = payrollId;
            this.LaborContractId = laborContractId;
            this.PayrollTypeId = payrollTypeId;
            this.PayrollNumber = payrollNumber;
            this.BasicSalary = basicSalary;
            this.Month = month;
            this.FortnightNumber = fortnightNumber;
            this.IssueDate = issueDate;
            this.Enabled = enabled;
        }

        /* ---------------------------------------------------------------- */
        /* Declaracion de Métodos de la clase PayrollMovement           */
        /* -----------------------------------------------------------------*/

        public long AddPayrollMovement()
        {
            return 0;
        }

        public PayrollMovement GetPayrollMovementById(long payrollId)
        {
            return new PayrollMovement();
        }

        public List<PayrollMovement> ListPayrollMovements()
        {
            return new List<PayrollMovement>();
        }

        public void ModifyPayrollMovement(long payrollId)
        {
        }

        public bool InabilityPayrollMovement()
        {
            return true;
        }
    }
}
