namespace VetSysControl.FORMULARIOS.Consulta {
    partial class FrmConsultaPet {
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
            DtGridView_Pet = new DataGridView();
            Txt_Chip = new TextBox();
            Lbl_Chip = new Label();
            Btn_Buscar = new Button();
            Lbl_Codigo = new Label();
            Txt_Codigo = new TextBox();
            Lbl_Nome = new Label();
            Txt_Nome = new TextBox();
            Lbl_Raca = new Label();
            Txt_Raca = new TextBox();
            Lbl_Especie = new Label();
            Txt_Especie = new TextBox();
            Lbl_Cliente = new Label();
            Txt_Cliente = new TextBox();
            GrpBox_ConsultaPet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Pet).BeginInit();
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
            GrpBox_ConsultaPet.Controls.Add(Lbl_Cliente);
            GrpBox_ConsultaPet.Controls.Add(Txt_Cliente);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Raca);
            GrpBox_ConsultaPet.Controls.Add(Txt_Raca);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Especie);
            GrpBox_ConsultaPet.Controls.Add(Txt_Especie);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Nome);
            GrpBox_ConsultaPet.Controls.Add(Txt_Nome);
            GrpBox_ConsultaPet.Controls.Add(Txt_Chip);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Chip);
            GrpBox_ConsultaPet.Controls.Add(Btn_Buscar);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Codigo);
            GrpBox_ConsultaPet.Controls.Add(Txt_Codigo);
            GrpBox_ConsultaPet.Location = new Point(12, 12);
            GrpBox_ConsultaPet.Name = "GrpBox_ConsultaPet";
            GrpBox_ConsultaPet.Size = new Size(776, 72);
            GrpBox_ConsultaPet.TabIndex = 61;
            GrpBox_ConsultaPet.TabStop = false;
            GrpBox_ConsultaPet.Text = "Consulta";
            // 
            // DtGridView_Pet
            // 
            DtGridView_Pet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGridView_Pet.Location = new Point(12, 90);
            DtGridView_Pet.Name = "DtGridView_Pet";
            DtGridView_Pet.Size = new Size(776, 306);
            DtGridView_Pet.TabIndex = 62;
            // 
            // Txt_Chip
            // 
            Txt_Chip.Location = new Point(226, 16);
            Txt_Chip.Name = "Txt_Chip";
            Txt_Chip.Size = new Size(93, 23);
            Txt_Chip.TabIndex = 74;
            // 
            // Lbl_Chip
            // 
            Lbl_Chip.AutoSize = true;
            Lbl_Chip.Location = new Point(185, 19);
            Lbl_Chip.Name = "Lbl_Chip";
            Lbl_Chip.Size = new Size(35, 15);
            Lbl_Chip.TabIndex = 73;
            Lbl_Chip.Text = "Chip:";
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
            // Lbl_Codigo
            // 
            Lbl_Codigo.AutoSize = true;
            Lbl_Codigo.Location = new Point(6, 19);
            Lbl_Codigo.Name = "Lbl_Codigo";
            Lbl_Codigo.Size = new Size(49, 15);
            Lbl_Codigo.TabIndex = 71;
            Lbl_Codigo.Text = "Código:";
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.Location = new Point(58, 16);
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(119, 23);
            Txt_Codigo.TabIndex = 70;
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.Location = new Point(324, 21);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(43, 15);
            Lbl_Nome.TabIndex = 76;
            Lbl_Nome.Text = "Nome:";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(373, 16);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(299, 23);
            Txt_Nome.TabIndex = 75;
            // 
            // Lbl_Raca
            // 
            Lbl_Raca.AutoSize = true;
            Lbl_Raca.Location = new Point(247, 49);
            Lbl_Raca.Name = "Lbl_Raca";
            Lbl_Raca.Size = new Size(35, 15);
            Lbl_Raca.TabIndex = 80;
            Lbl_Raca.Text = "Raça:";
            // 
            // Txt_Raca
            // 
            Txt_Raca.Location = new Point(288, 44);
            Txt_Raca.Name = "Txt_Raca";
            Txt_Raca.Size = new Size(183, 23);
            Txt_Raca.TabIndex = 79;
            // 
            // Lbl_Especie
            // 
            Lbl_Especie.AutoSize = true;
            Lbl_Especie.Location = new Point(6, 47);
            Lbl_Especie.Name = "Lbl_Especie";
            Lbl_Especie.Size = new Size(49, 15);
            Lbl_Especie.TabIndex = 78;
            Lbl_Especie.Text = "Especie:";
            // 
            // Txt_Especie
            // 
            Txt_Especie.Location = new Point(58, 44);
            Txt_Especie.Name = "Txt_Especie";
            Txt_Especie.Size = new Size(183, 23);
            Txt_Especie.TabIndex = 77;
            // 
            // Lbl_Cliente
            // 
            Lbl_Cliente.AutoSize = true;
            Lbl_Cliente.Location = new Point(477, 47);
            Lbl_Cliente.Name = "Lbl_Cliente";
            Lbl_Cliente.Size = new Size(47, 15);
            Lbl_Cliente.TabIndex = 82;
            Lbl_Cliente.Text = "Cliente:";
            // 
            // Txt_Cliente
            // 
            Txt_Cliente.Location = new Point(530, 43);
            Txt_Cliente.Name = "Txt_Cliente";
            Txt_Cliente.Size = new Size(142, 23);
            Txt_Cliente.TabIndex = 81;
            // 
            // ConsultaPet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DtGridView_Pet);
            Controls.Add(GrpBox_ConsultaPet);
            Controls.Add(Btn_Sair);
            Name = "ConsultaPet";
            Text = "ConsultaPet";
            GrpBox_ConsultaPet.ResumeLayout(false);
            GrpBox_ConsultaPet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Pet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Sair;
        private GroupBox GrpBox_ConsultaPet;
        private DataGridView DtGridView_Pet;
        private TextBox Txt_Chip;
        private Label Lbl_Chip;
        private Button Btn_Buscar;
        private Label Lbl_Codigo;
        private TextBox Txt_Codigo;
        private Label Lbl_Nome;
        private TextBox Txt_Nome;
        private Label Lbl_Raca;
        private TextBox Txt_Raca;
        private Label Lbl_Especie;
        private TextBox Txt_Especie;
        private Label Lbl_Cliente;
        private TextBox Txt_Cliente;
    }
}