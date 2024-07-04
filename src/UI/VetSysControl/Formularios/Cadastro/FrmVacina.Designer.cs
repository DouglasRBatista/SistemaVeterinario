namespace VetSysControl.FORMULARIOS.Cadastro {
    partial class FrmVacina {
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
            Btn_Excluir = new Button();
            Lbl_CadastroVac = new Label();
            Lbl_Codigo = new Label();
            Txt_Codigo = new TextBox();
            Lbl_Nome = new Label();
            Txt_Nome = new TextBox();
            Lbl_Desc = new Label();
            Txt_Desc = new TextBox();
            Lbl_Tipo = new Label();
            Txt_Tipo = new TextBox();
            Lbl_Fabricante = new Label();
            textBox1 = new TextBox();
            Lbl_Lote = new Label();
            Txt_Lote = new TextBox();
            Lbl_Validade = new Label();
            Dtp_Validade = new DateTimePicker();
            Lbl_QtdDose = new Label();
            Txt_QtdDose = new TextBox();
            Btn_Buscar = new Button();
            Btn_Editar = new Button();
            Btn_Salvar = new Button();
            Btn_Sair = new Button();
            Lbl_Periodicidade = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            Lbl_UnidTempo = new Label();
            SuspendLayout();
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.Location = new Point(909, 523);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(75, 23);
            Btn_Excluir.TabIndex = 0;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // Lbl_CadastroVac
            // 
            Lbl_CadastroVac.AutoSize = true;
            Lbl_CadastroVac.Location = new Point(37, 32);
            Lbl_CadastroVac.Name = "Lbl_CadastroVac";
            Lbl_CadastroVac.Size = new Size(112, 15);
            Lbl_CadastroVac.TabIndex = 1;
            Lbl_CadastroVac.Text = "Cadastro de Vacinas";
            // 
            // Lbl_Codigo
            // 
            Lbl_Codigo.AutoSize = true;
            Lbl_Codigo.Location = new Point(38, 86);
            Lbl_Codigo.Name = "Lbl_Codigo";
            Lbl_Codigo.Size = new Size(49, 15);
            Lbl_Codigo.TabIndex = 5;
            Lbl_Codigo.Text = "Código:";
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.Location = new Point(106, 83);
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(119, 23);
            Txt_Codigo.TabIndex = 4;
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.Location = new Point(364, 86);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(43, 15);
            Lbl_Nome.TabIndex = 7;
            Lbl_Nome.Text = "Nome:";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(431, 83);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(287, 23);
            Txt_Nome.TabIndex = 6;
            // 
            // Lbl_Desc
            // 
            Lbl_Desc.AutoSize = true;
            Lbl_Desc.Location = new Point(38, 220);
            Lbl_Desc.Name = "Lbl_Desc";
            Lbl_Desc.Size = new Size(61, 15);
            Lbl_Desc.TabIndex = 9;
            Lbl_Desc.Text = "Descrição:";
            // 
            // Txt_Desc
            // 
            Txt_Desc.Location = new Point(105, 217);
            Txt_Desc.Multiline = true;
            Txt_Desc.Name = "Txt_Desc";
            Txt_Desc.Size = new Size(696, 126);
            Txt_Desc.TabIndex = 8;
            // 
            // Lbl_Tipo
            // 
            Lbl_Tipo.AutoSize = true;
            Lbl_Tipo.Location = new Point(38, 140);
            Lbl_Tipo.Name = "Lbl_Tipo";
            Lbl_Tipo.Size = new Size(33, 15);
            Lbl_Tipo.TabIndex = 11;
            Lbl_Tipo.Text = "Tipo:";
            // 
            // Txt_Tipo
            // 
            Txt_Tipo.Location = new Point(105, 137);
            Txt_Tipo.Name = "Txt_Tipo";
            Txt_Tipo.Size = new Size(100, 23);
            Txt_Tipo.TabIndex = 10;
            // 
            // Lbl_Fabricante
            // 
            Lbl_Fabricante.AutoSize = true;
            Lbl_Fabricante.Location = new Point(227, 140);
            Lbl_Fabricante.Name = "Lbl_Fabricante";
            Lbl_Fabricante.Size = new Size(65, 15);
            Lbl_Fabricante.TabIndex = 13;
            Lbl_Fabricante.Text = "Fabricante:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 12;
            // 
            // Lbl_Lote
            // 
            Lbl_Lote.AutoSize = true;
            Lbl_Lote.Location = new Point(506, 140);
            Lbl_Lote.Name = "Lbl_Lote";
            Lbl_Lote.Size = new Size(33, 15);
            Lbl_Lote.TabIndex = 15;
            Lbl_Lote.Text = "Lote:";
            // 
            // Txt_Lote
            // 
            Txt_Lote.Location = new Point(545, 137);
            Txt_Lote.Name = "Txt_Lote";
            Txt_Lote.Size = new Size(100, 23);
            Txt_Lote.TabIndex = 14;
            // 
            // Lbl_Validade
            // 
            Lbl_Validade.AutoSize = true;
            Lbl_Validade.Location = new Point(38, 182);
            Lbl_Validade.Name = "Lbl_Validade";
            Lbl_Validade.Size = new Size(54, 15);
            Lbl_Validade.TabIndex = 16;
            Lbl_Validade.Text = "Validade:";
            // 
            // Dtp_Validade
            // 
            Dtp_Validade.Format = DateTimePickerFormat.Short;
            Dtp_Validade.Location = new Point(105, 179);
            Dtp_Validade.Name = "Dtp_Validade";
            Dtp_Validade.Size = new Size(100, 23);
            Dtp_Validade.TabIndex = 18;
            // 
            // Lbl_QtdDose
            // 
            Lbl_QtdDose.AutoSize = true;
            Lbl_QtdDose.Location = new Point(227, 182);
            Lbl_QtdDose.Name = "Lbl_QtdDose";
            Lbl_QtdDose.Size = new Size(56, 15);
            Lbl_QtdDose.TabIndex = 20;
            Lbl_QtdDose.Text = "QtdDose:";
            // 
            // Txt_QtdDose
            // 
            Txt_QtdDose.Location = new Point(298, 179);
            Txt_QtdDose.Name = "Txt_QtdDose";
            Txt_QtdDose.Size = new Size(57, 23);
            Txt_QtdDose.TabIndex = 19;
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.Location = new Point(250, 82);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(75, 23);
            Btn_Buscar.TabIndex = 21;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            Btn_Editar.Location = new Point(825, 523);
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Size = new Size(75, 23);
            Btn_Editar.TabIndex = 22;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Location = new Point(739, 523);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(75, 23);
            Btn_Salvar.TabIndex = 23;
            Btn_Salvar.Text = "Salvar";
            Btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(994, 523);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 24;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            // 
            // Lbl_Periodicidade
            // 
            Lbl_Periodicidade.AutoSize = true;
            Lbl_Periodicidade.Location = new Point(387, 182);
            Lbl_Periodicidade.Name = "Lbl_Periodicidade";
            Lbl_Periodicidade.Size = new Size(82, 15);
            Lbl_Periodicidade.TabIndex = 26;
            Lbl_Periodicidade.Text = "Periodicidade:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(475, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(680, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 27;
            // 
            // Lbl_UnidTempo
            // 
            Lbl_UnidTempo.AutoSize = true;
            Lbl_UnidTempo.Location = new Point(581, 182);
            Lbl_UnidTempo.Name = "Lbl_UnidTempo";
            Lbl_UnidTempo.Size = new Size(93, 15);
            Lbl_UnidTempo.TabIndex = 28;
            Lbl_UnidTempo.Text = "Unidade Tempo:";
            // 
            // FrmVacina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 569);
            Controls.Add(Lbl_UnidTempo);
            Controls.Add(comboBox1);
            Controls.Add(Lbl_Periodicidade);
            Controls.Add(textBox2);
            Controls.Add(Btn_Sair);
            Controls.Add(Btn_Salvar);
            Controls.Add(Btn_Editar);
            Controls.Add(Btn_Buscar);
            Controls.Add(Lbl_QtdDose);
            Controls.Add(Txt_QtdDose);
            Controls.Add(Dtp_Validade);
            Controls.Add(Lbl_Validade);
            Controls.Add(Lbl_Lote);
            Controls.Add(Txt_Lote);
            Controls.Add(Lbl_Fabricante);
            Controls.Add(textBox1);
            Controls.Add(Lbl_Tipo);
            Controls.Add(Txt_Tipo);
            Controls.Add(Lbl_Desc);
            Controls.Add(Txt_Desc);
            Controls.Add(Lbl_Nome);
            Controls.Add(Txt_Nome);
            Controls.Add(Lbl_Codigo);
            Controls.Add(Txt_Codigo);
            Controls.Add(Lbl_CadastroVac);
            Controls.Add(Btn_Excluir);
            Name = "FrmVacina";
            Text = "Vacina";
            Load += Vacina_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Excluir;
        private Label Lbl_CadastroVac;
        private Label Lbl_Codigo;
        private TextBox Txt_Codigo;
        private Label Lbl_Nome;
        private TextBox Txt_Nome;
        private Label Lbl_Desc;
        private TextBox Txt_Desc;
        private Label Lbl_Tipo;
        private TextBox Txt_Tipo;
        private Label Lbl_Fabricante;
        private TextBox textBox1;
        private Label Lbl_Lote;
        private TextBox Txt_Lote;
        private Label Lbl_Validade;
        private DateTimePicker Dtp_Validade;
        private Label Lbl_QtdDose;
        private TextBox Txt_QtdDose;
        private Button Btn_Buscar;
        private Button Btn_Editar;
        private Button Btn_Salvar;
        private Button Btn_Sair;
        private Label Lbl_Periodicidade;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label Lbl_UnidTempo;
    }
}