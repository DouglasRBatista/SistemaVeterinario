namespace VetSysControl.FORMULARIOS.Cadastro {
    partial class FrmAtendimento {
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
            components = new System.ComponentModel.Container();
            Lbl_CadastroAtend = new Label();
            Lbl_Titulo = new Label();
            Txt_Titulo = new TextBox();
            Btn_Sair = new Button();
            Btn_Salvar = new Button();
            Btn_Editar = new Button();
            Btn_Excluir = new Button();
            Txt_Desc = new TextBox();
            Lbl_DataAtend = new Label();
            Dtp_Data = new DateTimePicker();
            Dtp_Hora = new DateTimePicker();
            Lbl_Hora = new Label();
            Lbl_Cliente = new Label();
            Txt_Cliente = new TextBox();
            Lbl_Pet = new Label();
            textBox2 = new TextBox();
            Lbl_Vet = new Label();
            Txt_Vet = new TextBox();
            Lbl_Valor = new Label();
            imageList1 = new ImageList(components);
            Btn_BuscarCliente = new Button();
            Btn_BuscarVet = new Button();
            Btn_BuscarPet = new Button();
            GrpBox_Servicos = new GroupBox();
            Btn_DelServico = new Button();
            Btn_AddServ = new Button();
            DtGridView_Servicos = new DataGridView();
            GrpBox_Desc = new GroupBox();
            GrpBox_Pet = new GroupBox();
            Lbl_Vacinas = new Label();
            DtGridView_Vacinas = new DataGridView();
            Txt_Raca = new TextBox();
            Lbl_Raca = new Label();
            Txt_Especie = new TextBox();
            Lbl_Especie = new Label();
            Txt_Idade = new TextBox();
            Lbl_Idade = new Label();
            Dtp_DataNasc = new DateTimePicker();
            Lbl_DataNasc = new Label();
            GrpBox_Sexo = new GroupBox();
            RBtn_Femea = new RadioButton();
            RBtn_Macho = new RadioButton();
            DtGridView_Alergias = new DataGridView();
            Lbl_Alergias = new Label();
            Lbl_Atendimento = new Label();
            Txt_Atendimento = new TextBox();
            MskTxt_Valor = new MaskedTextBox();
            GrpBox_Servicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Servicos).BeginInit();
            GrpBox_Desc.SuspendLayout();
            GrpBox_Pet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Vacinas).BeginInit();
            GrpBox_Sexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Alergias).BeginInit();
            SuspendLayout();
            // 
            // Lbl_CadastroAtend
            // 
            Lbl_CadastroAtend.AutoSize = true;
            Lbl_CadastroAtend.Location = new Point(37, 32);
            Lbl_CadastroAtend.Name = "Lbl_CadastroAtend";
            Lbl_CadastroAtend.Size = new Size(148, 15);
            Lbl_CadastroAtend.TabIndex = 23;
            Lbl_CadastroAtend.Text = "Cadastro de Atendimentos";
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Location = new Point(37, 97);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(40, 15);
            Lbl_Titulo.TabIndex = 53;
            Lbl_Titulo.Text = "Titulo:";
            // 
            // Txt_Titulo
            // 
            Txt_Titulo.Location = new Point(117, 94);
            Txt_Titulo.Name = "Txt_Titulo";
            Txt_Titulo.Size = new Size(354, 23);
            Txt_Titulo.TabIndex = 52;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(994, 523);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 59;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Location = new Point(739, 523);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(75, 23);
            Btn_Salvar.TabIndex = 58;
            Btn_Salvar.Text = "Salvar";
            Btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            Btn_Editar.Location = new Point(825, 523);
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Size = new Size(75, 23);
            Btn_Editar.TabIndex = 57;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.Location = new Point(909, 523);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(75, 23);
            Btn_Excluir.TabIndex = 56;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // Txt_Desc
            // 
            Txt_Desc.Dock = DockStyle.Top;
            Txt_Desc.Location = new Point(3, 19);
            Txt_Desc.Multiline = true;
            Txt_Desc.Name = "Txt_Desc";
            Txt_Desc.Size = new Size(644, 101);
            Txt_Desc.TabIndex = 60;
            // 
            // Lbl_DataAtend
            // 
            Lbl_DataAtend.AutoSize = true;
            Lbl_DataAtend.Location = new Point(484, 97);
            Lbl_DataAtend.Name = "Lbl_DataAtend";
            Lbl_DataAtend.Size = new Size(34, 15);
            Lbl_DataAtend.TabIndex = 61;
            Lbl_DataAtend.Text = "Data:";
            // 
            // Dtp_Data
            // 
            Dtp_Data.Checked = false;
            Dtp_Data.Format = DateTimePickerFormat.Short;
            Dtp_Data.Location = new Point(540, 94);
            Dtp_Data.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            Dtp_Data.Name = "Dtp_Data";
            Dtp_Data.Size = new Size(96, 23);
            Dtp_Data.TabIndex = 62;
            // 
            // Dtp_Hora
            // 
            Dtp_Hora.CustomFormat = "H:m";
            Dtp_Hora.Format = DateTimePickerFormat.Custom;
            Dtp_Hora.Location = new Point(540, 124);
            Dtp_Hora.Name = "Dtp_Hora";
            Dtp_Hora.Size = new Size(96, 23);
            Dtp_Hora.TabIndex = 64;
            Dtp_Hora.TabStop = false;
            // 
            // Lbl_Hora
            // 
            Lbl_Hora.AutoSize = true;
            Lbl_Hora.Location = new Point(484, 127);
            Lbl_Hora.Name = "Lbl_Hora";
            Lbl_Hora.Size = new Size(50, 15);
            Lbl_Hora.TabIndex = 63;
            Lbl_Hora.Text = "Horário:";
            // 
            // Lbl_Cliente
            // 
            Lbl_Cliente.AutoSize = true;
            Lbl_Cliente.Location = new Point(37, 130);
            Lbl_Cliente.Name = "Lbl_Cliente";
            Lbl_Cliente.Size = new Size(47, 15);
            Lbl_Cliente.TabIndex = 66;
            Lbl_Cliente.Text = "Cliente:";
            // 
            // Txt_Cliente
            // 
            Txt_Cliente.Location = new Point(117, 127);
            Txt_Cliente.Name = "Txt_Cliente";
            Txt_Cliente.Size = new Size(260, 23);
            Txt_Cliente.TabIndex = 65;
            // 
            // Lbl_Pet
            // 
            Lbl_Pet.AutoSize = true;
            Lbl_Pet.Location = new Point(9, 26);
            Lbl_Pet.Name = "Lbl_Pet";
            Lbl_Pet.Size = new Size(27, 15);
            Lbl_Pet.TabIndex = 68;
            Lbl_Pet.Text = "Pet:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(51, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 67;
            // 
            // Lbl_Vet
            // 
            Lbl_Vet.AutoSize = true;
            Lbl_Vet.Location = new Point(37, 158);
            Lbl_Vet.Name = "Lbl_Vet";
            Lbl_Vet.Size = new Size(66, 15);
            Lbl_Vet.TabIndex = 69;
            Lbl_Vet.Text = "Veterinário:";
            // 
            // Txt_Vet
            // 
            Txt_Vet.Location = new Point(117, 156);
            Txt_Vet.Name = "Txt_Vet";
            Txt_Vet.Size = new Size(260, 23);
            Txt_Vet.TabIndex = 70;
            // 
            // Lbl_Valor
            // 
            Lbl_Valor.AutoSize = true;
            Lbl_Valor.Location = new Point(909, 477);
            Lbl_Valor.Name = "Lbl_Valor";
            Lbl_Valor.Size = new Size(36, 15);
            Lbl_Valor.TabIndex = 73;
            Lbl_Valor.Text = "Valor:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Btn_BuscarCliente
            // 
            Btn_BuscarCliente.Location = new Point(383, 127);
            Btn_BuscarCliente.Name = "Btn_BuscarCliente";
            Btn_BuscarCliente.Size = new Size(58, 23);
            Btn_BuscarCliente.TabIndex = 75;
            Btn_BuscarCliente.Text = "Buscar";
            Btn_BuscarCliente.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarVet
            // 
            Btn_BuscarVet.Location = new Point(383, 156);
            Btn_BuscarVet.Name = "Btn_BuscarVet";
            Btn_BuscarVet.Size = new Size(58, 23);
            Btn_BuscarVet.TabIndex = 76;
            Btn_BuscarVet.Text = "Buscar";
            Btn_BuscarVet.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarPet
            // 
            Btn_BuscarPet.Location = new Point(310, 22);
            Btn_BuscarPet.Name = "Btn_BuscarPet";
            Btn_BuscarPet.Size = new Size(58, 23);
            Btn_BuscarPet.TabIndex = 77;
            Btn_BuscarPet.Text = "Buscar";
            Btn_BuscarPet.UseVisualStyleBackColor = true;
            // 
            // GrpBox_Servicos
            // 
            GrpBox_Servicos.Controls.Add(Btn_DelServico);
            GrpBox_Servicos.Controls.Add(Btn_AddServ);
            GrpBox_Servicos.Controls.Add(DtGridView_Servicos);
            GrpBox_Servicos.Location = new Point(430, 190);
            GrpBox_Servicos.Name = "GrpBox_Servicos";
            GrpBox_Servicos.Size = new Size(650, 137);
            GrpBox_Servicos.TabIndex = 80;
            GrpBox_Servicos.TabStop = false;
            GrpBox_Servicos.Text = "Serviços";
            // 
            // Btn_DelServico
            // 
            Btn_DelServico.Location = new Point(588, 51);
            Btn_DelServico.Name = "Btn_DelServico";
            Btn_DelServico.Size = new Size(50, 23);
            Btn_DelServico.TabIndex = 82;
            Btn_DelServico.Text = "-";
            Btn_DelServico.UseVisualStyleBackColor = true;
            // 
            // Btn_AddServ
            // 
            Btn_AddServ.Location = new Point(588, 22);
            Btn_AddServ.Name = "Btn_AddServ";
            Btn_AddServ.Size = new Size(50, 23);
            Btn_AddServ.TabIndex = 81;
            Btn_AddServ.Text = "+";
            Btn_AddServ.UseVisualStyleBackColor = true;
            // 
            // DtGridView_Servicos
            // 
            DtGridView_Servicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGridView_Servicos.Location = new Point(6, 18);
            DtGridView_Servicos.Name = "DtGridView_Servicos";
            DtGridView_Servicos.Size = new Size(571, 109);
            DtGridView_Servicos.TabIndex = 80;
            // 
            // GrpBox_Desc
            // 
            GrpBox_Desc.Controls.Add(Txt_Desc);
            GrpBox_Desc.Location = new Point(430, 333);
            GrpBox_Desc.Name = "GrpBox_Desc";
            GrpBox_Desc.Size = new Size(650, 126);
            GrpBox_Desc.TabIndex = 81;
            GrpBox_Desc.TabStop = false;
            GrpBox_Desc.Text = "Descrição";
            // 
            // GrpBox_Pet
            // 
            GrpBox_Pet.Controls.Add(Lbl_Vacinas);
            GrpBox_Pet.Controls.Add(DtGridView_Vacinas);
            GrpBox_Pet.Controls.Add(Txt_Raca);
            GrpBox_Pet.Controls.Add(Lbl_Raca);
            GrpBox_Pet.Controls.Add(Txt_Especie);
            GrpBox_Pet.Controls.Add(Lbl_Especie);
            GrpBox_Pet.Controls.Add(Txt_Idade);
            GrpBox_Pet.Controls.Add(Lbl_Idade);
            GrpBox_Pet.Controls.Add(Dtp_DataNasc);
            GrpBox_Pet.Controls.Add(Lbl_DataNasc);
            GrpBox_Pet.Controls.Add(GrpBox_Sexo);
            GrpBox_Pet.Controls.Add(DtGridView_Alergias);
            GrpBox_Pet.Controls.Add(Lbl_Alergias);
            GrpBox_Pet.Controls.Add(Btn_BuscarPet);
            GrpBox_Pet.Controls.Add(textBox2);
            GrpBox_Pet.Controls.Add(Lbl_Pet);
            GrpBox_Pet.Location = new Point(37, 190);
            GrpBox_Pet.Name = "GrpBox_Pet";
            GrpBox_Pet.Size = new Size(387, 339);
            GrpBox_Pet.TabIndex = 82;
            GrpBox_Pet.TabStop = false;
            GrpBox_Pet.Text = "Pet";
            // 
            // Lbl_Vacinas
            // 
            Lbl_Vacinas.AutoSize = true;
            Lbl_Vacinas.Location = new Point(9, 144);
            Lbl_Vacinas.Name = "Lbl_Vacinas";
            Lbl_Vacinas.Size = new Size(49, 15);
            Lbl_Vacinas.TabIndex = 91;
            Lbl_Vacinas.Text = "Vacinas:";
            // 
            // DtGridView_Vacinas
            // 
            DtGridView_Vacinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGridView_Vacinas.Location = new Point(9, 162);
            DtGridView_Vacinas.Name = "DtGridView_Vacinas";
            DtGridView_Vacinas.Size = new Size(370, 76);
            DtGridView_Vacinas.TabIndex = 90;
            // 
            // Txt_Raca
            // 
            Txt_Raca.Location = new Point(64, 114);
            Txt_Raca.Name = "Txt_Raca";
            Txt_Raca.Size = new Size(216, 23);
            Txt_Raca.TabIndex = 88;
            // 
            // Lbl_Raca
            // 
            Lbl_Raca.AutoSize = true;
            Lbl_Raca.Location = new Point(9, 117);
            Lbl_Raca.Name = "Lbl_Raca";
            Lbl_Raca.Size = new Size(35, 15);
            Lbl_Raca.TabIndex = 89;
            Lbl_Raca.Text = "Raça:";
            // 
            // Txt_Especie
            // 
            Txt_Especie.Location = new Point(64, 85);
            Txt_Especie.Name = "Txt_Especie";
            Txt_Especie.Size = new Size(216, 23);
            Txt_Especie.TabIndex = 86;
            // 
            // Lbl_Especie
            // 
            Lbl_Especie.AutoSize = true;
            Lbl_Especie.Location = new Point(9, 88);
            Lbl_Especie.Name = "Lbl_Especie";
            Lbl_Especie.Size = new Size(49, 15);
            Lbl_Especie.TabIndex = 87;
            Lbl_Especie.Text = "Espécie:";
            // 
            // Txt_Idade
            // 
            Txt_Idade.Location = new Point(225, 56);
            Txt_Idade.Name = "Txt_Idade";
            Txt_Idade.Size = new Size(55, 23);
            Txt_Idade.TabIndex = 85;
            // 
            // Lbl_Idade
            // 
            Lbl_Idade.AutoSize = true;
            Lbl_Idade.Location = new Point(180, 59);
            Lbl_Idade.Name = "Lbl_Idade";
            Lbl_Idade.Size = new Size(39, 15);
            Lbl_Idade.TabIndex = 84;
            Lbl_Idade.Text = "Idade:";
            // 
            // Dtp_DataNasc
            // 
            Dtp_DataNasc.Format = DateTimePickerFormat.Short;
            Dtp_DataNasc.Location = new Point(81, 56);
            Dtp_DataNasc.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            Dtp_DataNasc.Name = "Dtp_DataNasc";
            Dtp_DataNasc.Size = new Size(93, 23);
            Dtp_DataNasc.TabIndex = 83;
            // 
            // Lbl_DataNasc
            // 
            Lbl_DataNasc.AutoSize = true;
            Lbl_DataNasc.Location = new Point(9, 59);
            Lbl_DataNasc.Name = "Lbl_DataNasc";
            Lbl_DataNasc.Size = new Size(66, 15);
            Lbl_DataNasc.TabIndex = 82;
            Lbl_DataNasc.Text = "Data Nasc.:";
            // 
            // GrpBox_Sexo
            // 
            GrpBox_Sexo.Controls.Add(RBtn_Femea);
            GrpBox_Sexo.Controls.Add(RBtn_Macho);
            GrpBox_Sexo.Location = new Point(291, 51);
            GrpBox_Sexo.Name = "GrpBox_Sexo";
            GrpBox_Sexo.Size = new Size(88, 84);
            GrpBox_Sexo.TabIndex = 81;
            GrpBox_Sexo.TabStop = false;
            GrpBox_Sexo.Text = "Sexo";
            // 
            // RBtn_Femea
            // 
            RBtn_Femea.AutoSize = true;
            RBtn_Femea.Location = new Point(19, 47);
            RBtn_Femea.Name = "RBtn_Femea";
            RBtn_Femea.Size = new Size(60, 19);
            RBtn_Femea.TabIndex = 1;
            RBtn_Femea.TabStop = true;
            RBtn_Femea.Text = "Fêmea";
            RBtn_Femea.UseVisualStyleBackColor = true;
            // 
            // RBtn_Macho
            // 
            RBtn_Macho.AutoSize = true;
            RBtn_Macho.Location = new Point(19, 22);
            RBtn_Macho.Name = "RBtn_Macho";
            RBtn_Macho.Size = new Size(62, 19);
            RBtn_Macho.TabIndex = 0;
            RBtn_Macho.TabStop = true;
            RBtn_Macho.Text = "Macho";
            RBtn_Macho.UseVisualStyleBackColor = true;
            // 
            // DtGridView_Alergias
            // 
            DtGridView_Alergias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGridView_Alergias.Location = new Point(9, 258);
            DtGridView_Alergias.Name = "DtGridView_Alergias";
            DtGridView_Alergias.Size = new Size(370, 65);
            DtGridView_Alergias.TabIndex = 80;
            // 
            // Lbl_Alergias
            // 
            Lbl_Alergias.AutoSize = true;
            Lbl_Alergias.Location = new Point(9, 240);
            Lbl_Alergias.Name = "Lbl_Alergias";
            Lbl_Alergias.Size = new Size(52, 15);
            Lbl_Alergias.TabIndex = 79;
            Lbl_Alergias.Text = "Alergias:";
            // 
            // Lbl_Atendimento
            // 
            Lbl_Atendimento.AutoSize = true;
            Lbl_Atendimento.Location = new Point(37, 66);
            Lbl_Atendimento.Name = "Lbl_Atendimento";
            Lbl_Atendimento.Size = new Size(80, 15);
            Lbl_Atendimento.TabIndex = 83;
            Lbl_Atendimento.Text = "Atendimento:";
            // 
            // Txt_Atendimento
            // 
            Txt_Atendimento.Location = new Point(117, 66);
            Txt_Atendimento.Name = "Txt_Atendimento";
            Txt_Atendimento.ReadOnly = true;
            Txt_Atendimento.Size = new Size(73, 23);
            Txt_Atendimento.TabIndex = 84;
            // 
            // MskTxt_Valor
            // 
            MskTxt_Valor.Location = new Point(951, 474);
            MskTxt_Valor.Name = "MskTxt_Valor";
            MskTxt_Valor.Size = new Size(118, 23);
            MskTxt_Valor.TabIndex = 85;
            // 
            // FrmAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 569);
            Controls.Add(MskTxt_Valor);
            Controls.Add(Txt_Atendimento);
            Controls.Add(Lbl_Atendimento);
            Controls.Add(Btn_BuscarVet);
            Controls.Add(Btn_BuscarCliente);
            Controls.Add(Lbl_Valor);
            Controls.Add(Txt_Vet);
            Controls.Add(Lbl_Vet);
            Controls.Add(Lbl_Cliente);
            Controls.Add(Txt_Cliente);
            Controls.Add(Dtp_Hora);
            Controls.Add(Lbl_Hora);
            Controls.Add(Dtp_Data);
            Controls.Add(Lbl_DataAtend);
            Controls.Add(Btn_Sair);
            Controls.Add(Btn_Salvar);
            Controls.Add(Btn_Editar);
            Controls.Add(Btn_Excluir);
            Controls.Add(Lbl_Titulo);
            Controls.Add(Txt_Titulo);
            Controls.Add(Lbl_CadastroAtend);
            Controls.Add(GrpBox_Pet);
            Controls.Add(GrpBox_Servicos);
            Controls.Add(GrpBox_Desc);
            Name = "FrmAtendimento";
            Text = "Atendimento";
            Load += FrmAtendimento_Load;
            GrpBox_Servicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtGridView_Servicos).EndInit();
            GrpBox_Desc.ResumeLayout(false);
            GrpBox_Desc.PerformLayout();
            GrpBox_Pet.ResumeLayout(false);
            GrpBox_Pet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Vacinas).EndInit();
            GrpBox_Sexo.ResumeLayout(false);
            GrpBox_Sexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Alergias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_CadastroAtend;
        private Label Lbl_Titulo;
        private TextBox Txt_Titulo;
        private Button Btn_Sair;
        private Button Btn_Salvar;
        private Button Btn_Editar;
        private Button Btn_Excluir;
        private TextBox Txt_Desc;
        private Label Lbl_DataAtend;
        private DateTimePicker Dtp_Data;
        private DateTimePicker Dtp_Hora;
        private Label Lbl_Hora;
        private Label Lbl_Cliente;
        private TextBox Txt_Cliente;
        private Label Lbl_Pet;
        private TextBox textBox2;
        private Label Lbl_Vet;
        private TextBox Txt_Vet;
        private Label Lbl_Valor;
        private ImageList imageList1;
        private Button Btn_BuscarCliente;
        private Button Btn_BuscarVet;
        private Button Btn_BuscarPet;
        private GroupBox GrpBox_Servicos;
        private GroupBox GrpBox_Desc;
        private GroupBox GrpBox_Pet;
        private Label Lbl_Alergias;
        private DataGridView DtGridView_Alergias;
        private GroupBox GrpBox_Sexo;
        private RadioButton RBtn_Femea;
        private RadioButton RBtn_Macho;
        private Label Lbl_Atendimento;
        private TextBox Txt_Atendimento;
        private TextBox Txt_Idade;
        private Label Lbl_Idade;
        private DateTimePicker Dtp_DataNasc;
        private Label Lbl_DataNasc;
        private Button Btn_DelServico;
        private Button Btn_AddServ;
        private DataGridView DtGridView_Servicos;
        private TextBox Txt_Raca;
        private Label Lbl_Raca;
        private TextBox Txt_Especie;
        private Label Lbl_Especie;
        private DataGridView DtGridView_Vacinas;
        private Label Lbl_Vacinas;
        private MaskedTextBox MskTxt_Valor;
    }
}