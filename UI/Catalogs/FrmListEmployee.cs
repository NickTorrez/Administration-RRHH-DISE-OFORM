using Administration_RRHH.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administration_RRHH.UI.Catalogs
{
    public partial class FrmListEmployee : Form
    {
        public FrmListEmployee()
        {
            InitializeComponent();
        }

        private void FrmListEmployee_Load(object sender, EventArgs e)
        {
            //Agregar de la lista de empleados del Json al DataGridView
            var employees = Employee.ListEmployee();

            //Configurar el DataGridView para mostrar solo las columnas necesarias
            dataGridView1.AutoGenerateColumns = false;
            // Limpiar columnas existentes
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCedula",
                HeaderText = "Cédula",
                DataPropertyName = "IdentityCard"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Name"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colApellido",
                HeaderText = "Apellido",
                DataPropertyName = "Surname"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFechaNacimiento",
                HeaderText = "Fecha de Nacimiento",
                DataPropertyName = "BirthDate"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEstadoCivil",
                HeaderText = "Estado Civil",
                DataPropertyName = "MaritalStatus"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colHijos",
                HeaderText = "Hijos",
                DataPropertyName = "NumberChildren"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTelefono",
                HeaderText = "Teléfono",
                DataPropertyName = "Phone"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEmail",
                HeaderText = "Email",
                DataPropertyName = "Email"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDireccion",
                HeaderText = "Dirección",
                DataPropertyName = "Address"
            });
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colActivo",
                HeaderText = "Activo",
                DataPropertyName = "IsActive"
            });

            dataGridView1.DataSource = employees;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string clave = mskIdentityCard.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Introduzca una cédula para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Intentar obtener la fuente original (si previamente guardaste la original en Tag, úsala)
            object source = dataGridView1.Tag ?? dataGridView1.DataSource;

            // Si es BindingSource, sacamos su DataSource real
            if (source is BindingSource bs) source = bs.DataSource;

            // Caso: DataTable
            if (source is DataTable dt)
            {
                // Filtrar por columna "colCedula" (escapar comillas simples)
                string safe = clave.Replace("'", "''");
                DataRow[] rows = dt.Select($"colCedula = '{safe}'");
                var filtered = dt.Clone();
                foreach (var r in rows) filtered.ImportRow(r);
                dataGridView1.DataSource = filtered;
                return;
            }

            // Caso: colección de Employee
            if (source is IEnumerable<Administration_RRHH.Domain.Employee> list)
            {
                var resultado = list
                    .Where(emp => string.Equals((emp.IdentityCard ?? string.Empty).Trim(), clave, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                dataGridView1.DataSource = new BindingSource { DataSource = resultado };
                return;
            }

            MessageBox.Show("No se pudo filtrar: tipo de origen desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }//end class
}//end namespace
