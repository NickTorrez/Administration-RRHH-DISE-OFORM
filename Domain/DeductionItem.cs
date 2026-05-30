using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Domain
{
    public class DeductionItem
    {
        /* ---------------------------------------------------------------- */
        /* Declaracion de Propiedades de la Clase DeductionItem         */
        /* -----------------------------------------------------------------*/

        public long DeductionId { get; set; }
        public long PayrollId { get; set; }
        public string DeductionType { get; set; }
        public decimal Amount { get; set; }
        public bool Enabled { get; set; }

        /* ---------------------------------------------------------------- */
        /* Declaracion de Constructores de la clase DeductionItem       */
        /* -----------------------------------------------------------------*/

        public DeductionItem()
        {
            this.DeductionId = 0;
            this.PayrollId = 0;
            this.DeductionType = string.Empty;
            this.Amount = 0.0m;
            this.Enabled = true;
        }

        public DeductionItem(long deductionId, long payrollId, string deductionType, decimal amount, bool enabled)
        {
            this.DeductionId = deductionId;
            this.PayrollId = payrollId;
            this.DeductionType = deductionType;
            this.Amount = amount;
            this.Enabled = enabled;
        }

        /* ---------------------------------------------------------------- */
        /* Declaracion de Métodos de la clase DeductionItem             */
        /* -----------------------------------------------------------------*/

        public long AddDeductionItem()
        {
            return 0;
        }

        public DeductionItem GetDeductionItemById(long deductionId)
        {
            return new DeductionItem();
        }

        public List<DeductionItem> ListDeductionItems()
        {
            return new List<DeductionItem>();
        }

        public void ModifyDeductionItem(long deductionId)
        {
        }

        public bool InabilityDeductionItem()
        {
            return true;
        }
    }
}
