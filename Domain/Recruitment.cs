using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Administration_RRHH.Domain
{
    public class Recruitment
    {
        /* ---------------------------------------------------- */
        /* Propiedades                                          */
        /* ---------------------------------------------------- */
        public DateOnly StartDate { get; set; } = DateOnly.MinValue;
        public DateOnly EndDate { get; set; } = DateOnly.MaxValue;
        public string TypeContract { get; set; } = string.Empty;
        public string ContractStatus { get; set; } = string.Empty;

        private int _contractNumber;
        public int ContractNumber
        {
            get => _contractNumber;
            set
            {
                if (value < 0)
                    throw new ArgumentException("No se ha especificado un número de contrato valido");
                _contractNumber = value;
            }
        }

        private int _workday;
        public int Workday
        {
            get => _workday;
            set
            {
                if (value < 0 || value > 8)
                    throw new ArgumentOutOfRangeException("Workday", "Jornada laboral fuera de rango.");
                _workday = value;
            }
        }

        /* ---------------------------------------------------- */
        /* Constructores                                        */
        /* ---------------------------------------------------- */
        public Recruitment() { }

        public Recruitment(DateOnly startDate, DateOnly endDate, string typeContract, string contractStatus, int workday)
        {
            StartDate = startDate;
            EndDate = endDate;
            TypeContract = typeContract;
            ContractStatus = contractStatus;
            Workday = workday;
        }

        /* ---------------------------------------------------- */
        /* Métodos                                              */
        /* ---------------------------------------------------- */
        public int AddRecruitment() => 1;
        public Recruitment ReadRecruitment(int numb) => new Recruitment();
        public List<Recruitment> ReadAllRecruitments() => new List<Recruitment>();
        public int UpdateRecruitment(int numb, Recruitment updateRecruit) => 1;

    }
}