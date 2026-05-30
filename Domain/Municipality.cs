using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Models
{
    public class Municipality
    {
        /* ---------------------------------------------------------------- */
        /*     Declaracion de Propiedades de la Clase Municipality             */
        /* -----------------------------------------------------------------*/

        public int MunicipalityId { get; set; } //Gestionado por la base de datos
        public Region region { get; set; } //Relacion de composicion, un municipio pertenece a una region
        //Propiedad de Navegacion de objetos Municipios en Obejtos Region 
        public string MunicipalityCode { get; set; } 
        public string MunicipalityName { get; set; }
        public bool Enabled { get; set; } //Indica si el municipio esta activo o no

        /* ---------------------------------------------------------------- */
        /*     Declaracion de Constructores de la clase Municipality           */
        /* -----------------------------------------------------------------*/

        public Municipality()
        {
            //Constructor por defecto, se puede usar para crear una instancia vacía de Municipality
            this.MunicipalityId = 0;
            this.region = new Region(); //Inicializar la propiedad de navegación con una nueva instancia de Region
            this.MunicipalityCode = string.Empty;
            this.MunicipalityName = string.Empty;
            this.Enabled = true; //Por defecto, el municipio está habilitado
        }

        public Municipality(int municipalityId, Region region, string municipalityCode, string municipalityName, bool enabled)
        {
            this.MunicipalityId = municipalityId;
            this.region = region;
            this.MunicipalityCode = municipalityCode;
            this.MunicipalityName = municipalityName;
            this.Enabled = enabled;
        }

        /* ---------------------------------------------------------------- */
        /*     Declaracion de Métodos de la clase Municipality                    */
        /* -----------------------------------------------------------------*/
        /// <summary>
        /// Agrega un nuevo municipio a la base de datos y retorna el ID del nuevo municipio creado.
        /// </summary>
        /// <returns></returns>
        public int AddMunicipality()
        {
            //Lógica para agregar un nuevo municipio a la base de datos
            //Retorna el ID del nuevo municipio creado
            return 0; //Valor de ejemplo, se debe reemplazar con la lógica real
        }   

        public Municipality GetMunicipalityByCode()
        {
            //Lógica para obtener un municipio por su código desde la base de datos
            //Retorna el municipio encontrado o null si no se encuentra
            return null; //Valor de ejemplo, se debe reemplazar con la lógica real
        }

        public List<Municipality> GetAllMunicipalities()
        {
            //Lógica para listar todas los municipios desde la base de datos
            //Retorna una lista de municipios
            return new List<Municipality>(); //Valor de ejemplo, se debe reemplazar con la lógica real
        }

        public void UpdateMunicipality(string code)
        {
            //Lógica para actualizar un municipio existente en la base de datos
            //No retorna ningún valor
        }   

        public bool RemoveMunicipality(string code)
        {
            //Lógica para eliminar un municipio de la base de datos
            //Retorna true si la eliminación fue exitosa, false en caso contrario
            return false; //
        }
    }//end-class
}//end-namespace
