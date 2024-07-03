namespace VetSysControl.FORMULARIOS.Consulta {
    partial class FrmConsultaCli {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Btn_Sair = new Button();
            GrpBox_ConsultaPet = new GroupBox();
            Lbl_Email = new Label();
            Txt_Email = new TextBox();
            Lbl_Nome = new Label();
            Txt_Nome = new TextBox();
            Txt_Telefone = new TextBox();
            Lbl_Telefone = new Label();
            Btn_Buscar = new Button();
            Lbl_CPF = new Label();
            Txt_CPF = new TextBox();
            DtGridView_Cliente = new DataGridView();
            GrpBox_ConsultaPet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Cliente).BeginInit();
            SuspendLayout();
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(706, 402);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 60;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            // 
            // GrpBox_ConsultaPet
            // 
            GrpBox_ConsultaPet.Controls.Add(Lbl_Email);
            GrpBox_ConsultaPet.Controls.Add(Txt_Email);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Nome);
            GrpBox_ConsultaPet.Controls.Add(Txt_Nome);
            GrpBox_ConsultaPet.Controls.Add(Txt_Telefone);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Telefone);
            GrpBox_ConsultaPet.Controls.Add(Btn_Buscar);
            GrpBox_ConsultaPet.Controls.Add(Lbl_CPF);
            GrpBox_ConsultaPet.Controls.Add(Txt_CPF);
            GrpBox_ConsultaPet.Location = new Point(12, 12);
            GrpBox_ConsultaPet.Name = "GrpBox_ConsultaPet";
            GrpBox_ConsultaPet.Size = new Size(776, 72);
            GrpBox_ConsultaPet.TabIndex = 61;
            GrpBox_ConsultaPet.TabStop = false;
            GrpBox_ConsultaPet.Text = "Consulta";
            // 
            // Lbl_Email
            // 
            Lbl_Email.AutoSize = true;
            Lbl_Email.Location = new Point(6, 47);
            Lbl_Email.Name = "Lbl_Email";
            Lbl_Email.Size = new Size(39, 15);
            Lbl_Email.TabIndex = 78;
            Lbl_Email.Text = "Email:";
            // 
            // Txt_Email
            // 
            Txt_Email.Location = new Point(58, 44);
            Txt_Email.Name = "Txt_Email";
            Txt_Email.Size = new Size(241, 23);
            Txt_Email.TabIndex = 77;
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.Location = new Point(180, 19);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(43, 15);
            Lbl_Nome.TabIndex = 76;
            Lbl_Nome.Text = "Nome:";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(229, 16);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(299, 23);
            Txt_Nome.TabIndex = 75;
            // 
            // Txt_Telefone
            // 
            Txt_Telefone.Location = new Point(379, 44);
            Txt_Telefone.Name = "Txt_Telefone";
            Txt_Telefone.Size = new Size(121, 23);
            Txt_Telefone.TabIndex = 74;
            // 
            // Lbl_Telefone
            // 
            Lbl_Telefone.AutoSize = true;
            Lbl_Telefone.Location = new Point(319, 47);
            Lbl_Telefone.Name = "Lbl_Telefone";
            Lbl_Telefone.Size = new Size(54, 15);
            Lbl_Telefone.TabIndex = 73;
            Lbl_Telefone.Text = "Telefone:";
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.Location = new Point(694, 43);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(75, 23);
            Btn_Buscar.TabIndex = 72;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Lbl_CPF
            // 
            Lbl_CPF.AutoSize = true;
            Lbl_CPF.Location = new Point(6, 19);
            Lbl_CPF.Name = "Lbl_CPF";
            Lbl_CPF.Size = new Size(31, 15);
            Lbl_CPF.TabIndex = 71;
            Lbl_CPF.Text = "CPF:";
            // 
            // Txt_CPF
            // 
            Txt_CPF.Location = new Point(58, 16);
            Txt_CPF.Name = "Txt_CPF";
            Txt_CPF.Size = new Size(119, 23);
            Txt_CPF.TabIndex = 70;
            // 
            // DtGridView_Cliente
            // 
            DtGridView_Cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGridView_Cliente.Location = new Point(12, 90);
            DtGridView_Cliente.Name = "DtGridView_Cliente";
            DtGridView_Cliente.Size = new Size(776, 306);
            DtGridView_Cliente.TabIndex = 62;
            // 
            // ConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DtGridView_Cliente);
            Controls.Add(GrpBox_ConsultaPet);
            Controls.Add(Btn_Sair);
            Name = "ConsultaCliente";
            Text = "ConsultaCliente";
            GrpBox_ConsultaPet.ResumeLayout(false);
            GrpBox_ConsultaPet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Cliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Buscar;
        private Button Btn_Sair;
        private GroupBox GrpBox_ConsultaPet;
        private Label Lbl_Telefone;
        private TextBox Txt_Telefone;
        private Label Lbl_Nome;
        private TextBox Txt_Nome;
        private Label Lbl_Email;
        private TextBox Txt_Email;
        private Label Lbl_CPF;
        private TextBox Txt_CPF;
        private DataGridView DtGridView_Cliente;
    }
}