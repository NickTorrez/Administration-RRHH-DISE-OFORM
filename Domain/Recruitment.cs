using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Administration_RRHH.Domain
{
    public class Recruitment
    {
        /* ---------------------------------------------------- */
        /* Campos / atributos                                   */
        /* ---------------------------------------------------- */
        private int _contractNumber;
        private DateOnly _startDate;
        private DateOnly _endDate;
        private string _typeContract;
        private string _contractStatus;
        private int _workday;

        /* ---------------------------------------------------- */
        /* Propiedades                                          */
        /* ---------------------------------------------------- */
        public int ContractNumber
        {
            get { return _contractNumber; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("No se ha especificado un número de contrato valido");
                _contractNumber = value;
            }//end of set
        }//end of ContractNumber

        public DateOnly StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }//end of StartDate

        public DateOnly EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }//end of EndDate

        public string TypeContract
        {
            get { return _typeContract; }
            set { _typeContract = value; }
        }//end of TypeContract

        public string ContractStatus
        {
            get { return _contractStatus; }
            set { _contractStatus = value; }
        }//end of ContractStatus

        public int Workday
        {
            get { return _workday; }
            set
            {
                if (value < 0 || value > 8)
                    throw new ArgumentOutOfRangeException("Workday", "Jornada laboral fuera de rango.");
                _workday = value;
            }
        }//end of Workday

        /* ---------------------------------------------------- */
        /* Constructores                                        */
        /* ---------------------------------------------------- */
        // Constructor por defecto
        public Recruitment()
        {
            _startDate = DateOnly.MinValue;
            _endDate = DateOnly.MaxValue;
            _typeContract = string.Empty;
            _contractStatus = string.Empty;
            _workday = 0;
        }//end of default constructor

        // Constructor con parámetros
        public Recruitment(DateOnly startDate, DateOnly endDate, string typeContract, string contractStatus, int workday)
        {
            _startDate = startDate;
            _endDate = endDate;
            _typeContract = typeContract;
            _contractStatus = contractStatus;
            Workday = workday; // Se usa la propiedad para aplicar la validación
        }

        /* ---------------------------------------------------- */
        /* Métodos                                              */
        /* ---------------------------------------------------- */
        public int AddRecruitment()
        {
            // Simulación de adición de datos
            // En un escenario real, aquí se insertaría el nuevo contrato en una base de datos y se generaría un número de contrato único.
            List<Recruitment> lstRecruitment = new List<Recruitment>();
            lstRecruitment.Add(this);

            if (lstRecruitment.Count > 0)
                return lstRecruitment.Count;// Simulación de generación de número de contrato único

            return 0;
        }

  
        public Recruitment ReadRecruitment(int numb)
        {
            // Simulación de lectura de datos
            List<Recruitment> lstRecruitment = new List<Recruitment>();
            lstRecruitment.Add(new Recruitment(DateOnly.FromDateTime(DateTime.Now.AddMonths(-1)), DateOnly.FromDateTime(DateTime.Now.AddMonths(11)), "Temporal", "Activo", 8) { ContractNumber = 1 });
            lstRecruitment.Add(new Recruitment(DateOnly.FromDateTime(DateTime.Now.AddMonths(-2)), DateOnly.FromDateTime(DateTime.Now.AddMonths(10)), "Permanente", "Activo", 8) { ContractNumber = 2 });
            lstRecruitment.Add(new Recruitment(DateOnly.FromDateTime(DateTime.Now.AddMonths(-3)), DateOnly.FromDateTime(DateTime.Now.AddMonths(9)), "Temporal", "Finalizado", 6) { ContractNumber = 3 });

            // Simulación de búsqueda de contrato por número de contrato
            var recruitment = lstRecruitment.FirstOrDefault(r => r.ContractNumber == numb);
            if (recruitment == null)
                throw new KeyNotFoundException("Referencia vacía o nula de un elemento Recruitment");

            return recruitment;
        }//end of ReadRecruitment

        public List<Recruitment> ReadAllRecruitments()
        {
            // Simulación de lectura de todos los contratos
            List<Recruitment> lstRecruitment = new List<Recruitment>();

            lstRecruitment.Add(new Recruitment(DateOnly.FromDateTime(DateTime.Now.AddMonths(-1)), DateOnly.FromDateTime(DateTime.Now.AddMonths(11)), "Temporal", "Activo", 8) { ContractNumber = 1 });
            lstRecruitment.Add(new Recruitment(DateOnly.FromDateTime(DateTime.Now.AddMonths(-2)), DateOnly.FromDateTime(DateTime.Now.AddMonths(10)), "Permanente", "Activo", 8) { ContractNumber = 2 });
            lstRecruitment.Add(new Recruitment(DateOnly.FromDateTime(DateTime.Now.AddMonths(-3)), DateOnly.FromDateTime(DateTime.Now.AddMonths(9)), "Temporal", "Finalizado", 6) { ContractNumber = 3 });

            return lstRecruitment;
        }//end of ReadAllRecruitments

        public int UpdateRecruitment(int numb, Recruitment updateRecruit)
        {
            List<Recruitment> lstRecruitment = new List<Recruitment>();
            lstRecruitment.Add(this);
            // Simulación de búsqueda de contrato por número de contrato
            var foundRecruitment = lstRecruitment.FirstOrDefault(r => r.ContractNumber == numb);
            if (foundRecruitment == null)
                throw new KeyNotFoundException("Referencia vacía o nula de un elemento Contrato");
            // Simulación de actualización de datos del contrato encontrado
            foundRecruitment.StartDate = updateRecruit.StartDate;
            foundRecruitment.EndDate = updateRecruit.EndDate;
            foundRecruitment.TypeContract = updateRecruit.TypeContract;
            foundRecruitment.ContractStatus = updateRecruit.ContractStatus;
            foundRecruitment.Workday = updateRecruit.Workday;

            return 1;
        }//end of UpdateRecruitment

        public int CancelRecruitment(int numb)
        {
            // Simulación de cancelación de contrato
            /* En un escenario real, aquí se actualizaría el estado del contrato a "Cancelado" en la base de datos. */
            /* Para esta simulación, simplemente se busca el contrato por número de contrato y se elimina de la lista. */
            List<Recruitment> lstRecruitment = new List<Recruitment>();
            lstRecruitment.Add(this);
            // Simulación de búsqueda de contrato por número de contrato
            var foundRecruitment = lstRecruitment.FirstOrDefault(r => r.ContractNumber == numb);
            if (foundRecruitment == null)
                throw new KeyNotFoundException("Referencia vacía o nula de un elemento Recruitment");

            lstRecruitment.Remove(foundRecruitment);
            return 1;
        }//end of CancelRecruitment

    }
}