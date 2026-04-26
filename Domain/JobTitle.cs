using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Administration_RRHH.Domain
{
    public class JobTitle
    {
        /* ---------------------------------------------------- */
        /* Campos / atributos            */
        /* ---------------------------------------------------- */
        private string _category;
        private string _jobCode;
        private string _jobTitle;
        private double _baseSalary;

        /* ---------------------------------------------------- */
        /* Propiedades                   */
        /* ---------------------------------------------------- */
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string JobCode
        {
            get { return _jobCode; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El código del puesto de trabajo no puede ser nulo o vacío.");

                _jobCode = value;
            }
        }

        public string JobTitleName
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public double BaseSalary
        {
            get { return _baseSalary; }
            set
            {
                if (value < 0)
                    _baseSalary = 0;
                else
                    _baseSalary = value;
            }
        }

        /* ---------------------------------------------------- */
        /* Constructores                 */
        /* ---------------------------------------------------- */
        // Constructor por defecto
        public JobTitle()
        {
            _category = string.Empty;
            _jobCode = string.Empty;
            _jobTitle = string.Empty;
            _baseSalary = 0.0;
        }//end constructor

        public JobTitle(string category, string jobCode, string jobTitle, double baseSalary)
        {
            _category = category;
            _jobCode = jobCode;
            _jobTitle = jobTitle;
            _baseSalary = baseSalary;
        }//end constructor

        /* ---------------------------------------------------- */
        /* Métodos                       */
        /* ---------------------------------------------------- */
        public int AddJobTitle()
        {
            // En un escenario real, este método interactuaría con una base de datos o un repositorio para agregar el puesto de trabajo.
            // Aquí se simula la adición del puesto de trabajo a una lista en memoria.
            List<JobTitle> lstJobTitle = new List<JobTitle>();
            lstJobTitle.Add(this);// Simula la adición del puesto de trabajo a la lista

            if (lstJobTitle.Count > 0)
                return lstJobTitle.Count;// Simula el número de registros afectados (en este caso, 1)

            return 0;
        }//end AddJobTitle

        public JobTitle ReadJobTitle(string jobCode)
        {
            // En un escenario real, este método interactuaría con una base de datos o un repositorio para obtener el puesto de trabajo por su código.
            // Aquí se simula la lectura del puesto de trabajo desde una lista en memoria.

            List<JobTitle> lstJobTitle = new List<JobTitle>();
            lstJobTitle.Add(new JobTitle("Recursos Humanos", "PST-001", "Gerente de Recursos Humanos", 50000.0));
            lstJobTitle.Add(new JobTitle("Finanzas", "PST-002", "Gerente de Finanzas", 60000.0));
            lstJobTitle.Add(new JobTitle("Tecnología", "PST-003", "Gerente de Tecnología", 70000.0));
            // Simula la búsqueda del puesto de trabajo por su código
            var jobTitle = lstJobTitle.FirstOrDefault(jt => jt.JobCode == jobCode);
            if (jobTitle == null)
                throw new KeyNotFoundException("Referencia vacía o nula de un elemento JobTitle");
            // Simula la devolución del puesto de trabajo encontrado
            return jobTitle;
        }//end ReadJobTitle

        public List<JobTitle> ReadAllJobTitles()
        {
            // En un escenario real, este método interactuaría con una base de datos o un repositorio para obtener todos los puestos de trabajo.
            List<JobTitle> lstJobTitle = new List<JobTitle>();
            lstJobTitle.Add(this);
            return lstJobTitle;
        }//end ReadAllJobTi

        public int UpdateJobTitle(string jobCode, JobTitle updatedJobTitle)
        {
            // En un escenario real, este método interactuaría con una base de datos o un repositorio para actualizar el puesto de trabajo por su código.
            List<JobTitle> lstJobTitle = new List<JobTitle>();
            // Simula la actualización del puesto de trabajo en una lista en memoria
            lstJobTitle.Add(new JobTitle("Recursos Humanos", "PST-001", "Gerente de Recursos Humanos", 50000.0));
            lstJobTitle.Add(new JobTitle("Finanzas", "PST-002", "Gerente de Finanzas", 60000.0));
            lstJobTitle.Add(new JobTitle("Tecnología", "PST-003", "Gerente de Tecnología", 70000.0));

            var foundJobTitle = lstJobTitle.FirstOrDefault(jt => jt.JobCode == jobCode);

            if (foundJobTitle == null)
                throw new KeyNotFoundException("Referencia vacía o nula de un elemento JobTitle");
            // Simula la actualización de los campos del puesto de trabajo encontrado
            foundJobTitle.Category = updatedJobTitle.Category;
            foundJobTitle.JobTitleName = updatedJobTitle.JobTitleName;
            foundJobTitle.BaseSalary = updatedJobTitle.BaseSalary;
            return 1;
        }//end UpdateJobTitle

        public bool DeleteJobTitle(string jobCode)
        {
            // En un escenario real, este método interactuaría con una base de datos o un repositorio para eliminar el puesto de trabajo por su código.
            // Aquí se simula la eliminación del puesto de trabajo desde una lista en memoria.

            List<JobTitle> lstJobTitle = new List<JobTitle>();
            lstJobTitle.Add(this);

            var foundJobTitle = lstJobTitle.FirstOrDefault(jt => jt.JobCode == jobCode);

            if (foundJobTitle == null)
                throw new KeyNotFoundException("Referencia vacía o nula de un elemento JobTitle con el código proporcionado");

            lstJobTitle.Remove(foundJobTitle);// Simula la eliminación del puesto de trabajo de la lista
            return true;
        }//end DeleteJobTitle

    }
}