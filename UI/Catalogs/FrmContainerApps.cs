using Administration_RRHH.UI.Admin;
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
    public partial class FrmContainerApps : Form
    {
        private Form? _activeForm = null; //Field

        public FrmContainerApps()
        {
            InitializeComponent();
            CustomizeNavigation();
            lblItems.Text = String.Empty;
            lblItems.Text = String.Empty;
        }

        private void FrmContainerApps_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Authentication());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void CustomizeNavigation()
        {
            //Custimoze the navigation bar appearence
            pnlSubMenuCatalog.Visible = false;
            pnlSubMenuContracts.Visible = false;
            pnlSubMenuPayroll.Visible = false;
            pnlSubMenuEmployee.Visible = false;
            pnlSubMenuReports.Visible = false;
            pnlSubMenuAdmin.Visible = false;

            // Ocultar todos los submenús al inicio
            HideSubMenu();

            // Limpiar los labels del breadcrumb por defecto
            lblMenu.Text = "";
            lblItems.Text = "";



        }//end-CustomizeNavigation


        /// <summary>
        /// Oculta todos los anuncios actualmente visibles en la interfaz de usuario 
        /// </summary>
        /// <remarks> Llame a este metodo para asegurarse de que ningun submenu permanezca visible</remarks>
        /// sumary


        private void HideSubMenu() //Oculta todos los submenus
        {
            //hide all submenus
            if (pnlSubMenuCatalog.Visible) pnlSubMenuCatalog.Visible = false;
            if (pnlSubMenuContracts.Visible) pnlSubMenuContracts.Visible = false;
            if (pnlSubMenuPayroll.Visible) pnlSubMenuPayroll.Visible = false;
            if (pnlSubMenuEmployee.Visible) pnlSubMenuEmployee.Visible = false;
            if (pnlSubMenuReports.Visible) pnlSubMenuReports.Visible = false;
            if (pnlSubMenuAdmin.Visible) pnlSubMenuAdmin.Visible = false;
        }//end-HideSubMenu

        private void ShowSubMenu(Panel subMenu) //Muestra el submenu seleccionado y oculta los demas submenus
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu(); //Oculta cualquier submenu visible
                subMenu.Visible = true; //Muestra el submenu seleccionado
            }
            else
            {
                subMenu.Visible = false; //Oculta cualquier submenu si aun esta visible
            }
        }//end-ShowSubMneu

        private void OpenChildForm(Form ChildForm) //
        {
            if (_activeForm != null)
            {
                _activeForm.Dispose();
                pnlContainer.Controls.Clear();

            }
            _activeForm = ChildForm;
            ChildForm.TopLevel = false;

            Panel hostPanel = new Panel();
            hostPanel.Dock = DockStyle.Fill;
            ChildForm.StartPosition = FormStartPosition.Manual;

            int x = (hostPanel.Width - ChildForm.Width / 2);
            int y = (hostPanel.Height - ChildForm.Height / 2);

            ChildForm.Location = new Point(x, y);

            hostPanel.Resize += (s, e) =>
            {
                int newX = (hostPanel.Width - ChildForm.Width) / 2;
                int newY = (hostPanel.Height - ChildForm.Height) / 2;
                ChildForm.Location = new Point(newX, newY);

            };

            hostPanel.Controls.Add(ChildForm);

            pnlContainer.Controls.Clear();

            pnlContainer.Controls.Add(hostPanel);

            ChildForm.Show();



        }//end-OpenChildForm

        private void btnCatalog_Click(object sender, EventArgs e) //Muestra el submenu de catalogo y actualiza el label del menu principal
        {
            ShowSubMenu(pnlSubMenuCatalog);
            if (!String.IsNullOrEmpty(lblMenu.Text))//Validar que el campo este vacio
                lblMenu.Text = "";//Limpiar el texto actual
            lblMenu.Text = "Catalogo /"; //Asignar el nuevo texto
        }

        private void btnEmployee_Click(object sender, EventArgs e) //Muestra el submenu de empleado y actualiza el label del menu principal
        {
            ShowSubMenu(pnlSubMenuEmployee);
            if (!String.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = "";
            lblMenu.Text = "Empleado /";
        }

        private void btnRecruitment_Click(object sender, EventArgs e) //Muestra el submenu de contratos y actualiza el label del menu principal
        {
            ShowSubMenu(pnlSubMenuContracts);
            //Validar que el campo quede vacio

            if (!String.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = "";
            lblMenu.Text = "Contratos /";
        }

        private void btnReport_Click(object sender, EventArgs e) //Muestra el submenu de reportes y actualiza el label del menu principal
        {
            ShowSubMenu(pnlSubMenuReports);
            if (!String.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = "";
            lblMenu.Text = "Reportes /";
        }

        private void btnPayroll_Click(object sender, EventArgs e) //Muestra el submenu de nomina y actualiza el label del menu principal
        {
            ShowSubMenu(pnlSubMenuPayroll);
            if (!String.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = "";
            lblMenu.Text = "Nómina /";
        }

        private void btnAdmin_Click(object sender, EventArgs e) //Muestra el submenu de nomina y actualiza el label del menu principal
        {
            lblMenu.Text = "";
            if (!String.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = "";
            lblMenu.Text = "Administración /";
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {

        }

        private void pnlSubMenuCatalog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMenuSideBar_Click(object sender, EventArgs e)
        {
            if(pnlSideBar.Width == 240)
            {
                pnlSideBar.Width = 60;
                lblMenu.Visible = false;
                
            }
            else
            {
                
            }
        }
    }//end-class


}//end-namespace
