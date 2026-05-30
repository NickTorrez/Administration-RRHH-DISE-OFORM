using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Domain
{
    public class AccruedItem
    {
        /* ---------------------------------------------------------------- */
        /* Declaracion de Propiedades de la Clase AccruedItem           */
        /* -----------------------------------------------------------------*/

        public long AccruedId { get; set; }
        public long PayrollId { get; set; }
        public string AccruedType { get; set; }
        public decimal Amount { get; set; }
        public bool Enabled { get; set; }

        /* ---------------------------------------------------------------- */
        /* Declaracion de Constructores de la clase AccruedItem         */
        /* -----------------------------------------------------------------*/

        public AccruedItem()
        {
            this.AccruedId = 0;
            this.PayrollId = 0;
            this.AccruedType = string.Empty;
            this.Amount = 0.0m;
            this.Enabled = true; // Por defecto habilitado (1 en SQL BIT)
        }

        public AccruedItem(long accruedId, long payrollId, string accruedType, decimal amount, bool enabled)
        {
            this.AccruedId = accruedId;
            this.PayrollId = payrollId;
            this.AccruedType = accruedType;
            this.Amount = amount;
            this.Enabled = enabled;
        }

        /* ---------------------------------------------------------------- */
        /* Declaracion de Métodos de la clase AccruedItem               */
        /* -----------------------------------------------------------------*/

        public long AddAccruedItem()
        {
            // Lógica para agregar un nuevo devengado a la base de datos
            return 0;
        }

        public AccruedItem GetAccruedItemById(long accruedId)
        {
            // Lógica para leer un devengado específico
            return new AccruedItem();
        }

        public List<AccruedItem> ListAccruedItems()
        {
            // Lógica para listar devengados
            return new List<AccruedItem>();
        }

        public void ModifyAccruedItem(long accruedId)
        {
            // Lógica para actualizar un devengado
        }

        public bool InabilityAccruedItem()
        {
            // Lógica para deshabilitar lógicamente un devengado
            return true;
        }
    }
}
