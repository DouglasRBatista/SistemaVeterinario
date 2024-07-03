namespace VetSysControl.FORMULARIOS.Cadastro {
    partial class Atendimento {
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
            Lbl_Descricao = new Label();
            Lbl_Titulo = new Label();
            Txt_Titulo = new TextBox();
            Btn_Sair = new Button();
            Btn_Salvar = new Button();
            Btn_Editar = new Button();
            Btn_Excluir = new Button();
            textBox1 = new TextBox();
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
            Lbl_Servico = new Label();
            CmbBox_Servico = new ComboBox();
            Txt_Valor = new TextBox();
            Lbl_Valor = new Label();
            imageList1 = new ImageList(components);
            Btn_BuscarCliente = new Button();
            Btn_BuscarVet = new Button();
            Btn_BuscarPet = new Button();
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
            // Lbl_Descricao
            // 
            Lbl_Descricao.AutoSize = true;
            Lbl_Descricao.Location = new Point(37, 235);
            Lbl_Descricao.Name = "Lbl_Descricao";
            Lbl_Descricao.Size = new Size(61, 15);
            Lbl_Descricao.TabIndex = 54;
            Lbl_Descricao.Text = "Descrição:";
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
            Txt_Titulo.Location = new Point(112, 94);
            Txt_Titulo.Name = "Txt_Titulo";
            Txt_Titulo.Size = new Size(354, 23);
            Txt_Titulo.TabIndex = 52;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(706, 402);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 59;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Location = new Point(451, 402);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(75, 23);
            Btn_Salvar.TabIndex = 58;
            Btn_Salvar.Text = "Salvar";
            Btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            Btn_Editar.Location = new Point(537, 402);
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Size = new Size(75, 23);
            Btn_Editar.TabIndex = 57;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.Location = new Point(621, 402);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(75, 23);
            Btn_Excluir.TabIndex = 56;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 232);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 94);
            textBox1.TabIndex = 60;
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
            Dtp_Data.Format = DateTimePickerFormat.Short;
            Dtp_Data.Location = new Point(524, 94);
            Dtp_Data.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            Dtp_Data.Name = "Dtp_Data";
            Dtp_Data.Size = new Size(96, 23);
            Dtp_Data.TabIndex = 62;
            // 
            // Dtp_Hora
            // 
            Dtp_Hora.CustomFormat = "H:m";
            Dtp_Hora.Format = DateTimePickerFormat.Custom;
            Dtp_Hora.Location = new Point(691, 94);
            Dtp_Hora.Name = "Dtp_Hora";
            Dtp_Hora.Size = new Size(96, 23);
            Dtp_Hora.TabIndex = 64;
            Dtp_Hora.TabStop = false;
            // 
            // Lbl_Hora
            // 
            Lbl_Hora.AutoSize = true;
            Lbl_Hora.Location = new Point(635, 97);
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
            Txt_Cliente.Location = new Point(112, 127);
            Txt_Cliente.Name = "Txt_Cliente";
            Txt_Cliente.Size = new Size(260, 23);
            Txt_Cliente.TabIndex = 65;
            // 
            // Lbl_Pet
            // 
            Lbl_Pet.AutoSize = true;
            Lbl_Pet.Location = new Point(442, 130);
            Lbl_Pet.Name = "Lbl_Pet";
            Lbl_Pet.Size = new Size(27, 15);
            Lbl_Pet.TabIndex = 68;
            Lbl_Pet.Text = "Pet:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(475, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 23);
            textBox2.TabIndex = 67;
            // 
            // Lbl_Vet
            // 
            Lbl_Vet.AutoSize = true;
            Lbl_Vet.Location = new Point(37, 166);
            Lbl_Vet.Name = "Lbl_Vet";
            Lbl_Vet.Size = new Size(66, 15);
            Lbl_Vet.TabIndex = 69;
            Lbl_Vet.Text = "Veterinário:";
            // 
            // Txt_Vet
            // 
            Txt_Vet.Location = new Point(112, 164);
            Txt_Vet.Name = "Txt_Vet";
            Txt_Vet.Size = new Size(260, 23);
            Txt_Vet.TabIndex = 70;
            // 
            // Lbl_Servico
            // 
            Lbl_Servico.AutoSize = true;
            Lbl_Servico.Location = new Point(37, 197);
            Lbl_Servico.Name = "Lbl_Servico";
            Lbl_Servico.Size = new Size(48, 15);
            Lbl_Servico.TabIndex = 71;
            Lbl_Servico.Text = "Serviço:";
            // 
            // CmbBox_Servico
            // 
            CmbBox_Servico.FormattingEnabled = true;
            CmbBox_Servico.Location = new Point(112, 197);
            CmbBox_Servico.Name = "CmbBox_Servico";
            CmbBox_Servico.Size = new Size(171, 23);
            CmbBox_Servico.TabIndex = 72;
            // 
            // Txt_Valor
            // 
            Txt_Valor.Location = new Point(369, 197);
            Txt_Valor.Name = "Txt_Valor";
            Txt_Valor.Size = new Size(97, 23);
            Txt_Valor.TabIndex = 74;
            // 
            // Lbl_Valor
            // 
            Lbl_Valor.AutoSize = true;
            Lbl_Valor.Location = new Point(306, 200);
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
            Btn_BuscarCliente.Location = new Point(378, 127);
            Btn_BuscarCliente.Name = "Btn_BuscarCliente";
            Btn_BuscarCliente.Size = new Size(58, 23);
            Btn_BuscarCliente.TabIndex = 75;
            Btn_BuscarCliente.Text = "Buscar";
            Btn_BuscarCliente.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarVet
            // 
            Btn_BuscarVet.Location = new Point(378, 164);
            Btn_BuscarVet.Name = "Btn_BuscarVet";
            Btn_BuscarVet.Size = new Size(58, 23);
            Btn_BuscarVet.TabIndex = 76;
            Btn_BuscarVet.Text = "Buscar";
            Btn_BuscarVet.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarPet
            // 
            Btn_BuscarPet.Location = new Point(740, 127);
            Btn_BuscarPet.Name = "Btn_BuscarPet";
            Btn_BuscarPet.Size = new Size(58, 23);
            Btn_BuscarPet.TabIndex = 77;
            Btn_BuscarPet.Text = "Buscar";
            Btn_BuscarPet.UseVisualStyleBackColor = true;
            // 
            // Atendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_BuscarPet);
            Controls.Add(Btn_BuscarVet);
            Controls.Add(Btn_BuscarCliente);
            Controls.Add(Txt_Valor);
            Controls.Add(Lbl_Valor);
            Controls.Add(CmbBox_Servico);
            Controls.Add(Lbl_Servico);
            Controls.Add(Txt_Vet);
            Controls.Add(Lbl_Vet);
            Controls.Add(Lbl_Pet);
            Controls.Add(textBox2);
            Controls.Add(Lbl_Cliente);
            Controls.Add(Txt_Cliente);
            Controls.Add(Dtp_Hora);
            Controls.Add(Lbl_Hora);
            Controls.Add(Dtp_Data);
            Controls.Add(Lbl_DataAtend);
            Controls.Add(textBox1);
            Controls.Add(Btn_Sair);
            Controls.Add(Btn_Salvar);
            Controls.Add(Btn_Editar);
            Controls.Add(Btn_Excluir);
            Controls.Add(Lbl_Descricao);
            Controls.Add(Lbl_Titulo);
            Controls.Add(Txt_Titulo);
            Controls.Add(Lbl_CadastroAtend);
            Name = "Atendimento";
            Text = "Atendimento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_CadastroAtend;
        private Label Lbl_Descricao;
        private Label Lbl_Titulo;
        private TextBox Txt_Titulo;
        private Button Btn_Sair;
        private Button Btn_Salvar;
        private Button Btn_Editar;
        private Button Btn_Excluir;
        private TextBox textBox1;
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
        private Label Lbl_Servico;
        private ComboBox CmbBox_Servico;
        private TextBox Txt_Valor;
        private Label Lbl_Valor;
        private ImageList imageList1;
        private Button Btn_BuscarCliente;
        private Button Btn_BuscarVet;
        private Button Btn_BuscarPet;
    }
}