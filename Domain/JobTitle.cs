using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Administration_RRHH.Domain
{
    public class JobTitle
    {
        /* ---------------------------------------------------- */
        /* Propiedades                                          */
        /* ---------------------------------------------------- */
        public string Category { get; set; } = string.Empty;
        public string JobTitleName { get; set; } = string.Empty;

        private string _jobCode = string.Empty;
        public string JobCode
        {
            get => _jobCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El código no puede ser nulo o vacío.");
                _jobCode = value;
            }
        }

        private double _baseSalary;
        public double BaseSalary
        {
            get => _baseSalary;
            set => _baseSalary = value < 0 ? 0 : value;
        }

        /* ---------------------------------------------------- */
        /* Constructores                                        */
        /* ---------------------------------------------------- */
        public JobTitle() { }

        public JobTitle(string category, string jobCode, string jobTitleName, double baseSalary)
        {
            Category = category;
            JobCode = jobCode;
            JobTitleName = jobTitleName;
            BaseSalary = baseSalary;
        }

        /* ---------------------------------------------------- */
        /* Métodos                                              */
        /* ---------------------------------------------------- */
        public int AddJobTitle() => 1;
        public JobTitle ReadJobTitle(string jobCode) => new JobTitle();
        public List<JobTitle> ReadAllJobTitles() => new List<JobTitle>();
        public int UpdateJobTitle(string jobCode, JobTitle updatedJobTitle) => 1;
        public bool DeleteJobTitle(string jobCode) => true;
    }
}