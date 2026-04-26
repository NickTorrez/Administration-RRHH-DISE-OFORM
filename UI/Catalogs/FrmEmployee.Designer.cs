namespace Administration_RRHH
{
    partial class FrmEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gprGeneralInfo = new GroupBox();
            tblLayoutGeneral = new TableLayoutPanel();
            label2 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            mskCedula = new MaskedTextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtBirthDate = new DateTimePicker();
            cmbMaritalStatus = new ComboBox();
            cmbChildren = new ComboBox();
            groupBox1 = new GroupBox();
            tblLayoutContact = new TableLayoutPanel();
            label7 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtPhone = new TextBox();
            label9 = new Label();
            txtAddress = new TextBox();
            panel1 = new Panel();
            BtnCancel = new Button();
            btnListEmployees = new Button();
            btnRegister = new Button();
            gprGeneralInfo.SuspendLayout();
            tblLayoutGeneral.SuspendLayout();
            groupBox1.SuspendLayout();
            tblLayoutContact.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gprGeneralInfo
            // 
            gprGeneralInfo.Controls.Add(tblLayoutGeneral);
            gprGeneralInfo.Dock = DockStyle.Top;
            gprGeneralInfo.Location = new Point(32, 32);
            gprGeneralInfo.Margin = new Padding(16);
            gprGeneralInfo.Name = "gprGeneralInfo";
            gprGeneralInfo.Padding = new Padding(16);
            gprGeneralInfo.Size = new Size(497, 314);
            gprGeneralInfo.TabIndex = 0;
            gprGeneralInfo.TabStop = false;
            gprGeneralInfo.Text = "Datos Generales";
            // 
            // tblLayoutGeneral
            // 
            tblLayoutGeneral.ColumnCount = 2;
            tblLayoutGeneral.ColumnStyles.Add(new ColumnStyle());
            tblLayoutGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayoutGeneral.Controls.Add(label2, 0, 1);
            tblLayoutGeneral.Controls.Add(txtName, 1, 1);
            tblLayoutGeneral.Controls.Add(txtSurname, 1, 2);
            tblLayoutGeneral.Controls.Add(mskCedula, 1, 0);
            tblLayoutGeneral.Controls.Add(label1, 0, 0);
            tblLayoutGeneral.Controls.Add(label3, 0, 2);
            tblLayoutGeneral.Controls.Add(label4, 0, 4);
            tblLayoutGeneral.Controls.Add(label5, 0, 5);
            tblLayoutGeneral.Controls.Add(label6, 0, 6);
            tblLayoutGeneral.Controls.Add(dtBirthDate, 1, 4);
            tblLayoutGeneral.Controls.Add(cmbMaritalStatus, 1, 5);
            tblLayoutGeneral.Controls.Add(cmbChildren, 1, 6);
            tblLayoutGeneral.Cursor = Cursors.Hand;
            tblLayoutGeneral.Dock = DockStyle.Fill;
            tblLayoutGeneral.Location = new Point(16, 32);
            tblLayoutGeneral.Margin = new Padding(4);
            tblLayoutGeneral.Name = "tblLayoutGeneral";
            tblLayoutGeneral.Padding = new Padding(16);
            tblLayoutGeneral.RowCount = 8;
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.Size = new Size(465, 266);
            tblLayoutGeneral.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(19, 67);
            label2.Margin = new Padding(3, 6, 3, 6);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(133, 63);
            txtName.Margin = new Padding(8);
            txtName.Name = "txtName";
            txtName.Size = new Size(308, 23);
            txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            txtSurname.Dock = DockStyle.Fill;
            txtSurname.Location = new Point(133, 102);
            txtSurname.Margin = new Padding(8);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(308, 23);
            txtSurname.TabIndex = 3;
            // 
            // mskCedula
            // 
            mskCedula.Dock = DockStyle.Fill;
            mskCedula.Location = new Point(133, 24);
            mskCedula.Margin = new Padding(8);
            mskCedula.Mask = "000-000000-0000L";
            mskCedula.Name = "mskCedula";
            mskCedula.Size = new Size(308, 23);
            mskCedula.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(19, 28);
            label1.Margin = new Padding(3, 6, 3, 6);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cédula";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(19, 106);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(19, 145);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(19, 184);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 7;
            label5.Text = "Estado Cívil";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(19, 223);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 8;
            label6.Text = "Hijos";
            // 
            // dtBirthDate
            // 
            dtBirthDate.CustomFormat = "dd/mm/yyyy";
            dtBirthDate.Dock = DockStyle.Fill;
            dtBirthDate.Format = DateTimePickerFormat.Short;
            dtBirthDate.Location = new Point(133, 141);
            dtBirthDate.Margin = new Padding(8);
            dtBirthDate.MaxDate = new DateTime(2031, 12, 30, 0, 0, 0, 0);
            dtBirthDate.MinDate = new DateTime(1974, 1, 1, 0, 0, 0, 0);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(308, 23);
            dtBirthDate.TabIndex = 4;
            // 
            // cmbMaritalStatus
            // 
            cmbMaritalStatus.Dock = DockStyle.Fill;
            cmbMaritalStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaritalStatus.FormattingEnabled = true;
            cmbMaritalStatus.Items.AddRange(new object[] { "Seleccionar", "Soltero", "Casado", "Union de hechos", "Divorciado", "Viudo" });
            cmbMaritalStatus.Location = new Point(133, 180);
            cmbMaritalStatus.Margin = new Padding(8);
            cmbMaritalStatus.Name = "cmbMaritalStatus";
            cmbMaritalStatus.Size = new Size(308, 23);
            cmbMaritalStatus.TabIndex = 5;
            // 
            // cmbChildren
            // 
            cmbChildren.Dock = DockStyle.Fill;
            cmbChildren.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChildren.FormattingEnabled = true;
            cmbChildren.Items.AddRange(new object[] { "Seleccionar", "0", "1", "2", "3", "4", "5", "6", "8", "9", "10" });
            cmbChildren.Location = new Point(133, 219);
            cmbChildren.Margin = new Padding(8);
            cmbChildren.Name = "cmbChildren";
            cmbChildren.Size = new Size(308, 23);
            cmbChildren.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tblLayoutContact);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(32, 388);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(16);
            groupBox1.Size = new Size(497, 270);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Contacto";
            // 
            // tblLayoutContact
            // 
            tblLayoutContact.ColumnCount = 2;
            tblLayoutContact.ColumnStyles.Add(new ColumnStyle());
            tblLayoutContact.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayoutContact.Controls.Add(label7, 0, 0);
            tblLayoutContact.Controls.Add(txtEmail, 1, 0);
            tblLayoutContact.Controls.Add(label8, 0, 1);
            tblLayoutContact.Controls.Add(txtPhone, 1, 1);
            tblLayoutContact.Controls.Add(label9, 0, 2);
            tblLayoutContact.Controls.Add(txtAddress, 1, 2);
            tblLayoutContact.Controls.Add(panel1, 0, 3);
            tblLayoutContact.Dock = DockStyle.Fill;
            tblLayoutContact.Location = new Point(16, 32);
            tblLayoutContact.Margin = new Padding(0);
            tblLayoutContact.Name = "tblLayoutContact";
            tblLayoutContact.Padding = new Padding(16);
            tblLayoutContact.RowCount = 4;
            tblLayoutContact.RowStyles.Add(new RowStyle());
            tblLayoutContact.RowStyles.Add(new RowStyle());
            tblLayoutContact.RowStyles.Add(new RowStyle());
            tblLayoutContact.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayoutContact.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayoutContact.Size = new Size(465, 222);
            tblLayoutContact.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(19, 28);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 0;
            label7.Text = "Correo";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(88, 24);
            txtEmail.Margin = new Padding(8);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(353, 23);
            txtEmail.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(19, 67);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 2;
            label8.Text = "Teléfono";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(88, 63);
            txtPhone.Margin = new Padding(8);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(353, 23);
            txtPhone.TabIndex = 8;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(19, 106);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 4;
            label9.Text = "Domicilio";
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(88, 102);
            txtAddress.Margin = new Padding(8);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(353, 23);
            txtAddress.TabIndex = 9;
            // 
            // panel1
            // 
            tblLayoutContact.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(BtnCancel);
            panel1.Controls.Add(btnListEmployees);
            panel1.Controls.Add(btnRegister);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(24, 141);
            panel1.Margin = new Padding(8);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8);
            panel1.Size = new Size(417, 57);
            panel1.TabIndex = 10;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Left;
            BtnCancel.Font = new Font("Segoe UI", 11F);
            BtnCancel.Location = new Point(293, 8);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(108, 40);
            BtnCancel.TabIndex = 12;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // btnListEmployees
            // 
            btnListEmployees.Anchor = AnchorStyles.Left;
            btnListEmployees.Font = new Font("Segoe UI", 11F);
            btnListEmployees.Location = new Point(169, 8);
            btnListEmployees.Name = "btnListEmployees";
            btnListEmployees.Size = new Size(108, 40);
            btnListEmployees.TabIndex = 11;
            btnListEmployees.Text = "Listar";
            btnListEmployees.UseVisualStyleBackColor = true;
            btnListEmployees.Click += btnListEmployees_Click;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Left;
            btnRegister.Font = new Font("Segoe UI", 11F);
            btnRegister.Location = new Point(16, 9);
            btnRegister.Margin = new Padding(0);
            btnRegister.Name = "btnRegister";
            btnRegister.Padding = new Padding(4);
            btnRegister.Size = new Size(137, 40);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Crear Empleado";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 690);
            Controls.Add(groupBox1);
            Controls.Add(gprGeneralInfo);
            Name = "FrmEmployee";
            Padding = new Padding(32);
            Text = "Empleado";
            gprGeneralInfo.ResumeLayout(false);
            tblLayoutGeneral.ResumeLayout(false);
            tblLayoutGeneral.PerformLayout();
            groupBox1.ResumeLayout(false);
            tblLayoutContact.ResumeLayout(false);
            tblLayoutContact.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gprGeneralInfo;
        private TableLayoutPanel tblLayoutGeneral;
        private MaskedTextBox mskCedula;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtSurname;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtBirthDate;
        private ComboBox cmbMaritalStatus;
        private ComboBox cmbChildren;
        private GroupBox groupBox1;
        private TableLayoutPanel tblLayoutContact;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtPhone;
        private Label label9;
        private TextBox txtAddress;
        private Button btnRegister;
        private Panel panel1;
        private Button btnListEmployees;
        private Button BtnCancel;
    }
}
