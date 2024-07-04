namespace VetSysControl.FORMULARIOS.Cadastro {
    partial class FrmServico {
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
            Lbl_CadastroServ = new Label();
            Btn_Buscar = new Button();
            Lbl_Desc = new Label();
            Txt_Desc = new TextBox();
            Lbl_Codigo = new Label();
            Txt_Codigo = new TextBox();
            Lbl_Valor = new Label();
            LstBox_Func = new ListBox();
            Btn_AddResp = new Button();
            Btn_DelResp = new Button();
            Btn_Sair = new Button();
            Btn_Salvar = new Button();
            Btn_Editar = new Button();
            Btn_Excluir = new Button();
            Btn_DelInsumos = new Button();
            Btn_AddInsumos = new Button();
            LstBox_Insumos = new ListBox();
            Btn_DelVac = new Button();
            Btn_AddVac = new Button();
            LstBox_Vac = new ListBox();
            GrpBox_Resp = new GroupBox();
            GrpBox_Vac = new GroupBox();
            groupBox1 = new GroupBox();
            MskBox_Valor = new MaskedTextBox();
            GrpBox_Resp.SuspendLayout();
            GrpBox_Vac.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_CadastroServ
            // 
            Lbl_CadastroServ.AutoSize = true;
            Lbl_CadastroServ.Location = new Point(37, 32);
            Lbl_CadastroServ.Name = "Lbl_CadastroServ";
            Lbl_CadastroServ.Size = new Size(116, 15);
            Lbl_CadastroServ.TabIndex = 23;
            Lbl_CadastroServ.Text = "Cadastro de Serviços";
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.Location = new Point(302, 82);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(75, 23);
            Btn_Buscar.TabIndex = 28;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Desc
            // 
            Lbl_Desc.AutoSize = true;
            Lbl_Desc.Location = new Point(37, 131);
            Lbl_Desc.Name = "Lbl_Desc";
            Lbl_Desc.Size = new Size(61, 15);
            Lbl_Desc.TabIndex = 27;
            Lbl_Desc.Text = "Descrição:";
            // 
            // Txt_Desc
            // 
            Txt_Desc.Location = new Point(104, 128);
            Txt_Desc.Name = "Txt_Desc";
            Txt_Desc.Size = new Size(378, 23);
            Txt_Desc.TabIndex = 26;
            // 
            // Lbl_Codigo
            // 
            Lbl_Codigo.AutoSize = true;
            Lbl_Codigo.Location = new Point(37, 86);
            Lbl_Codigo.Name = "Lbl_Codigo";
            Lbl_Codigo.Size = new Size(49, 15);
            Lbl_Codigo.TabIndex = 25;
            Lbl_Codigo.Text = "Código:";
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.Location = new Point(105, 83);
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(182, 23);
            Txt_Codigo.TabIndex = 24;
            // 
            // Lbl_Valor
            // 
            Lbl_Valor.AutoSize = true;
            Lbl_Valor.Location = new Point(552, 131);
            Lbl_Valor.Name = "Lbl_Valor";
            Lbl_Valor.Size = new Size(36, 15);
            Lbl_Valor.TabIndex = 29;
            Lbl_Valor.Text = "Valor:";
            // 
            // LstBox_Func
            // 
            LstBox_Func.Dock = DockStyle.Top;
            LstBox_Func.FormattingEnabled = true;
            LstBox_Func.ItemHeight = 15;
            LstBox_Func.Location = new Point(3, 19);
            LstBox_Func.Name = "LstBox_Func";
            LstBox_Func.Size = new Size(207, 319);
            LstBox_Func.TabIndex = 31;
            // 
            // Btn_AddResp
            // 
            Btn_AddResp.Location = new Point(168, 342);
            Btn_AddResp.Name = "Btn_AddResp";
            Btn_AddResp.Size = new Size(39, 23);
            Btn_AddResp.TabIndex = 33;
            Btn_AddResp.Text = "+";
            Btn_AddResp.UseVisualStyleBackColor = true;
            // 
            // Btn_DelResp
            // 
            Btn_DelResp.Location = new Point(123, 342);
            Btn_DelResp.Name = "Btn_DelResp";
            Btn_DelResp.Size = new Size(39, 23);
            Btn_DelResp.TabIndex = 34;
            Btn_DelResp.Text = "-";
            Btn_DelResp.UseVisualStyleBackColor = true;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(994, 523);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 47;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Location = new Point(739, 523);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(75, 23);
            Btn_Salvar.TabIndex = 46;
            Btn_Salvar.Text = "Salvar";
            Btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            Btn_Editar.Location = new Point(825, 523);
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Size = new Size(75, 23);
            Btn_Editar.TabIndex = 45;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.Location = new Point(909, 523);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(75, 23);
            Btn_Excluir.TabIndex = 44;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // Btn_DelInsumos
            // 
            Btn_DelInsumos.Location = new Point(123, 342);
            Btn_DelInsumos.Name = "Btn_DelInsumos";
            Btn_DelInsumos.Size = new Size(39, 23);
            Btn_DelInsumos.TabIndex = 51;
            Btn_DelInsumos.Text = "-";
            Btn_DelInsumos.UseVisualStyleBackColor = true;
            // 
            // Btn_AddInsumos
            // 
            Btn_AddInsumos.Location = new Point(168, 342);
            Btn_AddInsumos.Name = "Btn_AddInsumos";
            Btn_AddInsumos.Size = new Size(39, 23);
            Btn_AddInsumos.TabIndex = 50;
            Btn_AddInsumos.Text = "+";
            Btn_AddInsumos.UseVisualStyleBackColor = true;
            // 
            // LstBox_Insumos
            // 
            LstBox_Insumos.Dock = DockStyle.Top;
            LstBox_Insumos.FormattingEnabled = true;
            LstBox_Insumos.ItemHeight = 15;
            LstBox_Insumos.Location = new Point(3, 19);
            LstBox_Insumos.Name = "LstBox_Insumos";
            LstBox_Insumos.Size = new Size(207, 319);
            LstBox_Insumos.TabIndex = 48;
            // 
            // Btn_DelVac
            // 
            Btn_DelVac.Location = new Point(123, 342);
            Btn_DelVac.Name = "Btn_DelVac";
            Btn_DelVac.Size = new Size(39, 23);
            Btn_DelVac.TabIndex = 55;
            Btn_DelVac.Text = "-";
            Btn_DelVac.UseVisualStyleBackColor = true;
            // 
            // Btn_AddVac
            // 
            Btn_AddVac.Location = new Point(168, 342);
            Btn_AddVac.Name = "Btn_AddVac";
            Btn_AddVac.Size = new Size(39, 23);
            Btn_AddVac.TabIndex = 54;
            Btn_AddVac.Text = "+";
            Btn_AddVac.UseVisualStyleBackColor = true;
            // 
            // LstBox_Vac
            // 
            LstBox_Vac.Dock = DockStyle.Top;
            LstBox_Vac.FormattingEnabled = true;
            LstBox_Vac.ItemHeight = 15;
            LstBox_Vac.Location = new Point(3, 19);
            LstBox_Vac.Name = "LstBox_Vac";
            LstBox_Vac.Size = new Size(207, 319);
            LstBox_Vac.TabIndex = 52;
            // 
            // GrpBox_Resp
            // 
            GrpBox_Resp.Controls.Add(LstBox_Func);
            GrpBox_Resp.Controls.Add(Btn_AddResp);
            GrpBox_Resp.Controls.Add(Btn_DelResp);
            GrpBox_Resp.Location = new Point(37, 157);
            GrpBox_Resp.Name = "GrpBox_Resp";
            GrpBox_Resp.Size = new Size(213, 371);
            GrpBox_Resp.TabIndex = 56;
            GrpBox_Resp.TabStop = false;
            GrpBox_Resp.Text = "Responsável";
            // 
            // GrpBox_Vac
            // 
            GrpBox_Vac.Controls.Add(LstBox_Vac);
            GrpBox_Vac.Controls.Add(Btn_AddVac);
            GrpBox_Vac.Controls.Add(Btn_DelVac);
            GrpBox_Vac.Location = new Point(275, 157);
            GrpBox_Vac.Name = "GrpBox_Vac";
            GrpBox_Vac.Size = new Size(213, 371);
            GrpBox_Vac.TabIndex = 57;
            GrpBox_Vac.TabStop = false;
            GrpBox_Vac.Text = "Vacinas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LstBox_Insumos);
            groupBox1.Controls.Add(Btn_AddInsumos);
            groupBox1.Controls.Add(Btn_DelInsumos);
            groupBox1.Location = new Point(516, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 371);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insumos";
            // 
            // MskBox_Valor
            // 
            MskBox_Valor.Location = new Point(594, 128);
            MskBox_Valor.Name = "MskBox_Valor";
            MskBox_Valor.Size = new Size(127, 23);
            MskBox_Valor.TabIndex = 59;
            // 
            // FrmServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 569);
            Controls.Add(MskBox_Valor);
            Controls.Add(Btn_Sair);
            Controls.Add(Btn_Salvar);
            Controls.Add(Btn_Editar);
            Controls.Add(Btn_Excluir);
            Controls.Add(Lbl_Valor);
            Controls.Add(Btn_Buscar);
            Controls.Add(Lbl_Desc);
            Controls.Add(Txt_Desc);
            Controls.Add(Lbl_Codigo);
            Controls.Add(Txt_Codigo);
            Controls.Add(Lbl_CadastroServ);
            Controls.Add(groupBox1);
            Controls.Add(GrpBox_Vac);
            Controls.Add(GrpBox_Resp);
            Name = "FrmServico";
            Text = "Servico";
            GrpBox_Resp.ResumeLayout(false);
            GrpBox_Vac.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_CadastroServ;
        private Button Btn_Buscar;
        private Label Lbl_Desc;
        private TextBox Txt_Desc;
        private Label Lbl_Codigo;
        private TextBox Txt_Codigo;
        private Label Lbl_Valor;
        private ListBox LstBox_Func;
        private Button Btn_AddResp;
        private Button Btn_DelResp;
        private Button Btn_Sair;
        private Button Btn_Salvar;
        private Button Btn_Editar;
        private Button Btn_Excluir;
        private Button Btn_DelInsumos;
        private Button Btn_AddInsumos;
        private ListBox LstBox_Insumos;
        private Button Btn_DelVac;
        private Button Btn_AddVac;
        private ListBox LstBox_Vac;
        private GroupBox GrpBox_Resp;
        private GroupBox GrpBox_Vac;
        private GroupBox groupBox1;
        private MaskedTextBox MskBox_Valor;
    }
}