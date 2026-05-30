using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Models
{
    public class Region
    {
        /* ---------------------------------------------------------------- */
        /*     Declaracion de Propiedades de la Clase Region                */
        /* -----------------------------------------------------------------*/

        public int RegionId { get; set; }
        public string RegionCode { get; set; }
        public string Description { get; set; }
        public string Enabled { get; set; } //Indica si la region esta activa o no 

        /* ---------------------------------------------------------------- */
        /*     Declaracion de Constructores de la clase Region              */
        /* -----------------------------------------------------------------*/

        public Region ()
        {
            //Constructor por defecto, se puede usar para crear una instancia vacía de Region
            this.RegionId = 0;
            this.RegionCode = string.Empty;
            this.Description = string.Empty;
            this.Enabled = "Y"; //Por defecto, la región está habilitada
        }

        public Region (int regionId, string regionCode, string description, string enabled)
        {
            this.RegionId = regionId;
            this.RegionCode = regionCode;
            this.Description = description;
            this.Enabled = enabled;
        }

        /* ---------------------------------------------------------------- */
        /*     Declaracion de Métodos de la clase Region                    */
        /* -----------------------------------------------------------------*/

        public int AddRegion()
        {
            //Lógica para agregar una nueva región a la base de datos
            //Retorna el ID de la nueva región creada
            return 0; //Valor de ejemplo, se debe reemplazar con la lógica real
        }

        public Region GetRegionByCode(int regionId)
        {
            //Lógica para leer una región específica desde la base de datos utilizando su ID
            return new Region(); //Valor de ejemplo, se debe reemplazar con la lógica real
        }

        public List<Region> ListRegions()
        {
            //Lógica para listar todas las regiones desde la base de datos
            return new List<Region>(); //Valor de ejemplo, se debe reemplazar con la lógica real
        }

        public void ModifyRegion(string code)
        {
            //Lógica para actualizar una región existente en la base de datos
           //Valor de ejemplo, se debe reemplazar con la lógica real
        }
        public bool InabilityRegion()
        {
            //Lógica para deshabilitar una región en la base de datos
            return true; //Valor de ejemplo, se debe reemplazar con la lógica real
        }

    }
}
