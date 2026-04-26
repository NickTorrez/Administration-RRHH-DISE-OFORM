namespace Administration_RRHH.UI.Catalogs
{
    partial class FrmListEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            mskIdentityCard = new MaskedTextBox();
            btnSearch = new Button();
            btnCreate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 37);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "Empleados";
            // 
            // mskIdentityCard
            // 
            mskIdentityCard.Anchor = AnchorStyles.Left;
            mskIdentityCard.Location = new Point(48, 82);
            mskIdentityCard.Mask = "000-000000-0000L";
            mskIdentityCard.Name = "mskIdentityCard";
            mskIdentityCard.Size = new Size(171, 23);
            mskIdentityCard.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left;
            btnSearch.Location = new Point(239, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Right;
            btnCreate.Location = new Point(790, 81);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(108, 32);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Crear Empleado";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(864, 475);
            dataGridView1.TabIndex = 5;
            // 
            // FrmListEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 705);
            Controls.Add(dataGridView1);
            Controls.Add(btnCreate);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(mskIdentityCard);
            Name = "FrmListEmployee";
            Text = "Registros de Empleados";
            Load += FrmListEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox mskIdentityCard;
        private Button btnSearch;
        private Button btnCreate;
        private DataGridView dataGridView1;
    }
}