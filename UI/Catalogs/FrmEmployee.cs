using Administration_RRHH.Domain;
using Administration_RRHH.UI.Catalogs;

namespace Administration_RRHH
{
    public partial class FrmEmployee : Form
    {
        //Crear instancia de la clase Employee
        Employee _employee;
        public FrmEmployee()
        {
            InitializeComponent();
            _employee = new Employee();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Normalizar posibles nulls de los controles antes de asignar a propiedades no anulables
            _employee.IdentityCard = mskCedula.Text ?? string.Empty;
            _employee.Name = txtName.Text ?? string.Empty;
            _employee.Surname = txtSurname.Text ?? string.Empty;
            //Obtener la fecha del DateTimePicker, no es nullable
            DateTime birthDate = dtBirthDate.Value;
            // Convertir a DateOnly y asignar a la propiedad BirthDate
            _employee.BirthDate = DateOnly.FromDateTime(birthDate);
            // Evitar desreferencia de SelectedItem si es null
            _employee.MaritalStatus = cmbMaritalStatus.SelectedItem?.ToString() ?? string.Empty;
            string children = cmbChildren.SelectedItem?.ToString() ?? "0";
            _employee.NumberChildren = Convert.ToInt32(children); //Convertir a entero
            _employee.Address = txtAddress.Text ?? string.Empty;

            // Asignar 0 si no se selecciona nada
            _employee.Email = txtEmail.Text ?? string.Empty;
            _employee.Phone = txtPhone.Text ?? string.Empty;

            if (_employee.AddEmployee())
            {
                MessageBox.Show("Empleado registrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrar el empleado");
            }//end if-else
        }

        private void btnListEmployees_Click(object sender, EventArgs e)
        {
            FrmListEmployee viewListEmpployee = new FrmListEmployee();
            viewListEmpployee.Show();
            this.Hide();

        }//end-btnListEmployees_Click
    }//end class
}//end namespace
