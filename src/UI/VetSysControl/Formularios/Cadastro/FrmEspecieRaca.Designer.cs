﻿namespace VetSysControl.FORMULARIOS.Cadastro {
    partial class FrmEspecieRaca {
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
            Lbl_Especie = new Label();
            Lbl_Raca = new Label();
            Txt_CodEspecie = new TextBox();
            Lbl_CodEspecie = new Label();
            label2 = new Label();
            Txt_DescEspecie = new TextBox();
            Lbl_TipoEspecie = new Label();
            Txt_DescRaca = new TextBox();
            Lbl_DescRaca = new Label();
            Lbl_CodRaca = new Label();
            Txt_CodRaca = new TextBox();
            GrpBox_Temperatura = new GroupBox();
            Txt_TempCorpMax = new TextBox();
            Lbl_TempCorpMin = new Label();
            Lbl_TempCorpMax = new Label();
            Txt_TempCorpMin = new TextBox();
            GrpBox_ExpecVida = new GroupBox();
            Txt_ExpecVidaMax = new TextBox();
            Lbl_ExpecVidaMin = new Label();
            Lbl_ExpecVidaMax = new Label();
            Txt_ExpecVidaMin = new TextBox();
            Txt_OBS = new TextBox();
            CmbBox_TipoEspecie = new ComboBox();
            GrpBox_OBS = new GroupBox();
            GrpBox_PesoPorIdade = new GroupBox();
            Lbl_Faixa2 = new Label();
            Lbl_Faixa = new Label();
            Txt_PesoMax = new TextBox();
            Txt_PesoMin = new TextBox();
            Lbl_PesoMax = new Label();
            Lbl_PesoMin = new Label();
            Txt_IdadeMax = new TextBox();
            Txt_IdadeMin = new TextBox();
            label1 = new Label();
            Lbl_IdadeMin = new Label();
            Btn_Del = new Button();
            Btn_Add = new Button();
            DtGridView_PesoPorIdade = new DataGridView();
            Btn_Sair = new Button();
            Btn_Salvar = new Button();
            Btn_Editar = new Button();
            Btn_Excluir = new Button();
            Btn_BuscarRaca = new Button();
            Btn_BuscarEspecie = new Button();
            GrpBox_Temperatura.SuspendLayout();
            GrpBox_ExpecVida.SuspendLayout();
            GrpBox_OBS.SuspendLayout();
            GrpBox_PesoPorIdade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_PesoPorIdade).BeginInit();
            SuspendLayout();
            // 
            // Lbl_Especie
            // 
            Lbl_Especie.AutoSize = true;
            Lbl_Especie.Location = new Point(37, 32);
            Lbl_Especie.Name = "Lbl_Especie";
            Lbl_Especie.Size = new Size(112, 15);
            Lbl_Especie.TabIndex = 24;
            Lbl_Especie.Text = "Cadastro de Especie";
            // 
            // Lbl_Raca
            // 
            Lbl_Raca.AutoSize = true;
            Lbl_Raca.Location = new Point(37, 218);
            Lbl_Raca.Name = "Lbl_Raca";
            Lbl_Raca.Size = new Size(98, 15);
            Lbl_Raca.TabIndex = 25;
            Lbl_Raca.Text = "Cadastro de Raça";
            // 
            // Txt_CodEspecie
            // 
            Txt_CodEspecie.Location = new Point(150, 94);
            Txt_CodEspecie.MaxLength = 20;
            Txt_CodEspecie.Name = "Txt_CodEspecie";
            Txt_CodEspecie.Size = new Size(175, 23);
            Txt_CodEspecie.TabIndex = 26;
            // 
            // Lbl_CodEspecie
            // 
            Lbl_CodEspecie.AutoSize = true;
            Lbl_CodEspecie.Location = new Point(37, 97);
            Lbl_CodEspecie.Name = "Lbl_CodEspecie";
            Lbl_CodEspecie.Size = new Size(107, 15);
            Lbl_CodEspecie.TabIndex = 27;
            Lbl_CodEspecie.Text = "Codigo da Especie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 97);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 28;
            label2.Text = "Descrição:";
            // 
            // Txt_DescEspecie
            // 
            Txt_DescEspecie.Location = new Point(481, 94);
            Txt_DescEspecie.MaxLength = 50;
            Txt_DescEspecie.Name = "Txt_DescEspecie";
            Txt_DescEspecie.Size = new Size(220, 23);
            Txt_DescEspecie.TabIndex = 29;
            // 
            // Lbl_TipoEspecie
            // 
            Lbl_TipoEspecie.AutoSize = true;
            Lbl_TipoEspecie.Location = new Point(724, 97);
            Lbl_TipoEspecie.Name = "Lbl_TipoEspecie";
            Lbl_TipoEspecie.Size = new Size(33, 15);
            Lbl_TipoEspecie.TabIndex = 30;
            Lbl_TipoEspecie.Text = "Tipo:";
            // 
            // Txt_DescRaca
            // 
            Txt_DescRaca.Location = new Point(155, 305);
            Txt_DescRaca.MaxLength = 50;
            Txt_DescRaca.Name = "Txt_DescRaca";
            Txt_DescRaca.Size = new Size(241, 23);
            Txt_DescRaca.TabIndex = 35;
            // 
            // Lbl_DescRaca
            // 
            Lbl_DescRaca.AutoSize = true;
            Lbl_DescRaca.Location = new Point(42, 308);
            Lbl_DescRaca.Name = "Lbl_DescRaca";
            Lbl_DescRaca.Size = new Size(61, 15);
            Lbl_DescRaca.TabIndex = 34;
            Lbl_DescRaca.Text = "Descrição:";
            // 
            // Lbl_CodRaca
            // 
            Lbl_CodRaca.AutoSize = true;
            Lbl_CodRaca.Location = new Point(42, 273);
            Lbl_CodRaca.Name = "Lbl_CodRaca";
            Lbl_CodRaca.Size = new Size(93, 15);
            Lbl_CodRaca.TabIndex = 33;
            Lbl_CodRaca.Text = "Codigo da Raca:";
            // 
            // Txt_CodRaca
            // 
            Txt_CodRaca.Location = new Point(155, 270);
            Txt_CodRaca.MaxLength = 20;
            Txt_CodRaca.Name = "Txt_CodRaca";
            Txt_CodRaca.Size = new Size(170, 23);
            Txt_CodRaca.TabIndex = 32;
            // 
            // GrpBox_Temperatura
            // 
            GrpBox_Temperatura.Controls.Add(Txt_TempCorpMax);
            GrpBox_Temperatura.Controls.Add(Lbl_TempCorpMin);
            GrpBox_Temperatura.Controls.Add(Lbl_TempCorpMax);
            GrpBox_Temperatura.Controls.Add(Txt_TempCorpMin);
            GrpBox_Temperatura.Location = new Point(458, 256);
            GrpBox_Temperatura.Name = "GrpBox_Temperatura";
            GrpBox_Temperatura.Size = new Size(243, 100);
            GrpBox_Temperatura.TabIndex = 36;
            GrpBox_Temperatura.TabStop = false;
            GrpBox_Temperatura.Text = "Temperatura Corporal";
            // 
            // Txt_TempCorpMax
            // 
            Txt_TempCorpMax.Location = new Point(156, 61);
            Txt_TempCorpMax.Name = "Txt_TempCorpMax";
            Txt_TempCorpMax.Size = new Size(72, 23);
            Txt_TempCorpMax.TabIndex = 40;
            // 
            // Lbl_TempCorpMin
            // 
            Lbl_TempCorpMin.AutoSize = true;
            Lbl_TempCorpMin.Location = new Point(6, 29);
            Lbl_TempCorpMin.Name = "Lbl_TempCorpMin";
            Lbl_TempCorpMin.Size = new Size(144, 15);
            Lbl_TempCorpMin.TabIndex = 38;
            Lbl_TempCorpMin.Text = "Temperatura Mínima (ºC):";
            // 
            // Lbl_TempCorpMax
            // 
            Lbl_TempCorpMax.AutoSize = true;
            Lbl_TempCorpMax.Location = new Point(6, 64);
            Lbl_TempCorpMax.Name = "Lbl_TempCorpMax";
            Lbl_TempCorpMax.Size = new Size(146, 15);
            Lbl_TempCorpMax.TabIndex = 39;
            Lbl_TempCorpMax.Text = "Temperatura Máxima (ºC):";
            // 
            // Txt_TempCorpMin
            // 
            Txt_TempCorpMin.Location = new Point(156, 26);
            Txt_TempCorpMin.Name = "Txt_TempCorpMin";
            Txt_TempCorpMin.Size = new Size(72, 23);
            Txt_TempCorpMin.TabIndex = 37;
            // 
            // GrpBox_ExpecVida
            // 
            GrpBox_ExpecVida.Controls.Add(Txt_ExpecVidaMax);
            GrpBox_ExpecVida.Controls.Add(Lbl_ExpecVidaMin);
            GrpBox_ExpecVida.Controls.Add(Lbl_ExpecVidaMax);
            GrpBox_ExpecVida.Controls.Add(Txt_ExpecVidaMin);
            GrpBox_ExpecVida.Location = new Point(739, 256);
            GrpBox_ExpecVida.Name = "GrpBox_ExpecVida";
            GrpBox_ExpecVida.Size = new Size(238, 100);
            GrpBox_ExpecVida.TabIndex = 41;
            GrpBox_ExpecVida.TabStop = false;
            GrpBox_ExpecVida.Text = "Expectativa de Vida";
            // 
            // Txt_ExpecVidaMax
            // 
            Txt_ExpecVidaMax.Location = new Point(156, 61);
            Txt_ExpecVidaMax.MaxLength = 3;
            Txt_ExpecVidaMax.Name = "Txt_ExpecVidaMax";
            Txt_ExpecVidaMax.Size = new Size(72, 23);
            Txt_ExpecVidaMax.TabIndex = 40;
            // 
            // Lbl_ExpecVidaMin
            // 
            Lbl_ExpecVidaMin.AutoSize = true;
            Lbl_ExpecVidaMin.Location = new Point(6, 29);
            Lbl_ExpecVidaMin.Name = "Lbl_ExpecVidaMin";
            Lbl_ExpecVidaMin.Size = new Size(139, 15);
            Lbl_ExpecVidaMin.TabIndex = 38;
            Lbl_ExpecVidaMin.Text = "Expectativa de Vida Min.:";
            // 
            // Lbl_ExpecVidaMax
            // 
            Lbl_ExpecVidaMax.AutoSize = true;
            Lbl_ExpecVidaMax.Location = new Point(6, 64);
            Lbl_ExpecVidaMax.Name = "Lbl_ExpecVidaMax";
            Lbl_ExpecVidaMax.Size = new Size(141, 15);
            Lbl_ExpecVidaMax.TabIndex = 39;
            Lbl_ExpecVidaMax.Text = "Expectativa de Vida Max.:";
            // 
            // Txt_ExpecVidaMin
            // 
            Txt_ExpecVidaMin.Location = new Point(156, 26);
            Txt_ExpecVidaMin.MaxLength = 3;
            Txt_ExpecVidaMin.Name = "Txt_ExpecVidaMin";
            Txt_ExpecVidaMin.Size = new Size(72, 23);
            Txt_ExpecVidaMin.TabIndex = 37;
            // 
            // Txt_OBS
            // 
            Txt_OBS.Dock = DockStyle.Top;
            Txt_OBS.Location = new Point(3, 19);
            Txt_OBS.Multiline = true;
            Txt_OBS.Name = "Txt_OBS";
            Txt_OBS.Size = new Size(389, 112);
            Txt_OBS.TabIndex = 42;
            // 
            // CmbBox_TipoEspecie
            // 
            CmbBox_TipoEspecie.FormattingEnabled = true;
            CmbBox_TipoEspecie.Location = new Point(763, 94);
            CmbBox_TipoEspecie.Name = "CmbBox_TipoEspecie";
            CmbBox_TipoEspecie.Size = new Size(204, 23);
            CmbBox_TipoEspecie.TabIndex = 44;
            // 
            // GrpBox_OBS
            // 
            GrpBox_OBS.Controls.Add(Txt_OBS);
            GrpBox_OBS.Location = new Point(42, 371);
            GrpBox_OBS.Name = "GrpBox_OBS";
            GrpBox_OBS.Size = new Size(395, 137);
            GrpBox_OBS.TabIndex = 45;
            GrpBox_OBS.TabStop = false;
            GrpBox_OBS.Text = "OBS";
            // 
            // GrpBox_PesoPorIdade
            // 
            GrpBox_PesoPorIdade.Controls.Add(Lbl_Faixa2);
            GrpBox_PesoPorIdade.Controls.Add(Lbl_Faixa);
            GrpBox_PesoPorIdade.Controls.Add(Txt_PesoMax);
            GrpBox_PesoPorIdade.Controls.Add(Txt_PesoMin);
            GrpBox_PesoPorIdade.Controls.Add(Lbl_PesoMax);
            GrpBox_PesoPorIdade.Controls.Add(Lbl_PesoMin);
            GrpBox_PesoPorIdade.Controls.Add(Txt_IdadeMax);
            GrpBox_PesoPorIdade.Controls.Add(Txt_IdadeMin);
            GrpBox_PesoPorIdade.Controls.Add(label1);
            GrpBox_PesoPorIdade.Controls.Add(Lbl_IdadeMin);
            GrpBox_PesoPorIdade.Controls.Add(Btn_Del);
            GrpBox_PesoPorIdade.Controls.Add(Btn_Add);
            GrpBox_PesoPorIdade.Controls.Add(DtGridView_PesoPorIdade);
            GrpBox_PesoPorIdade.Location = new Point(458, 371);
            GrpBox_PesoPorIdade.Name = "GrpBox_PesoPorIdade";
            GrpBox_PesoPorIdade.Size = new Size(602, 137);
            GrpBox_PesoPorIdade.TabIndex = 41;
            GrpBox_PesoPorIdade.TabStop = false;
            GrpBox_PesoPorIdade.Text = "Peso Por Idade";
            // 
            // Lbl_Faixa2
            // 
            Lbl_Faixa2.AutoSize = true;
            Lbl_Faixa2.Location = new Point(483, 80);
            Lbl_Faixa2.Name = "Lbl_Faixa2";
            Lbl_Faixa2.Size = new Size(15, 15);
            Lbl_Faixa2.TabIndex = 59;
            Lbl_Faixa2.Text = "~";
            // 
            // Lbl_Faixa
            // 
            Lbl_Faixa.AutoSize = true;
            Lbl_Faixa.Location = new Point(483, 36);
            Lbl_Faixa.Name = "Lbl_Faixa";
            Lbl_Faixa.Size = new Size(15, 15);
            Lbl_Faixa.TabIndex = 52;
            Lbl_Faixa.Text = "~";
            // 
            // Txt_PesoMax
            // 
            Txt_PesoMax.Location = new Point(515, 78);
            Txt_PesoMax.MaxLength = 20;
            Txt_PesoMax.Name = "Txt_PesoMax";
            Txt_PesoMax.Size = new Size(70, 23);
            Txt_PesoMax.TabIndex = 58;
            // 
            // Txt_PesoMin
            // 
            Txt_PesoMin.Location = new Point(395, 78);
            Txt_PesoMin.MaxLength = 20;
            Txt_PesoMin.Name = "Txt_PesoMin";
            Txt_PesoMin.Size = new Size(70, 23);
            Txt_PesoMin.TabIndex = 55;
            // 
            // Lbl_PesoMax
            // 
            Lbl_PesoMax.AutoSize = true;
            Lbl_PesoMax.Location = new Point(515, 60);
            Lbl_PesoMax.Name = "Lbl_PesoMax";
            Lbl_PesoMax.Size = new Size(64, 15);
            Lbl_PesoMax.TabIndex = 57;
            Lbl_PesoMax.Text = "Peso Max.:";
            // 
            // Lbl_PesoMin
            // 
            Lbl_PesoMin.AutoSize = true;
            Lbl_PesoMin.Location = new Point(395, 60);
            Lbl_PesoMin.Name = "Lbl_PesoMin";
            Lbl_PesoMin.Size = new Size(62, 15);
            Lbl_PesoMin.TabIndex = 56;
            Lbl_PesoMin.Text = "Peso Min.:";
            // 
            // Txt_IdadeMax
            // 
            Txt_IdadeMax.Location = new Point(515, 34);
            Txt_IdadeMax.MaxLength = 20;
            Txt_IdadeMax.Name = "Txt_IdadeMax";
            Txt_IdadeMax.Size = new Size(70, 23);
            Txt_IdadeMax.TabIndex = 54;
            // 
            // Txt_IdadeMin
            // 
            Txt_IdadeMin.Location = new Point(395, 34);
            Txt_IdadeMin.MaxLength = 20;
            Txt_IdadeMin.Name = "Txt_IdadeMin";
            Txt_IdadeMin.Size = new Size(70, 23);
            Txt_IdadeMin.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(515, 16);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 53;
            label1.Text = "Idade Max.:";
            // 
            // Lbl_IdadeMin
            // 
            Lbl_IdadeMin.AutoSize = true;
            Lbl_IdadeMin.Location = new Point(395, 16);
            Lbl_IdadeMin.Name = "Lbl_IdadeMin";
            Lbl_IdadeMin.Size = new Size(66, 15);
            Lbl_IdadeMin.TabIndex = 52;
            Lbl_IdadeMin.Text = "Idade Min.:";
            // 
            // Btn_Del
            // 
            Btn_Del.Location = new Point(533, 108);
            Btn_Del.Name = "Btn_Del";
            Btn_Del.Size = new Size(58, 23);
            Btn_Del.TabIndex = 2;
            Btn_Del.Text = "-";
            Btn_Del.UseVisualStyleBackColor = true;
            // 
            // Btn_Add
            // 
            Btn_Add.Location = new Point(469, 108);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(58, 23);
            Btn_Add.TabIndex = 1;
            Btn_Add.Text = "+";
            Btn_Add.UseVisualStyleBackColor = true;
            // 
            // DtGridView_PesoPorIdade
            // 
            DtGridView_PesoPorIdade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGridView_PesoPorIdade.Location = new Point(3, 19);
            DtGridView_PesoPorIdade.Name = "DtGridView_PesoPorIdade";
            DtGridView_PesoPorIdade.Size = new Size(378, 92);
            DtGridView_PesoPorIdade.TabIndex = 0;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(994, 523);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 49;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Location = new Point(739, 523);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(75, 23);
            Btn_Salvar.TabIndex = 48;
            Btn_Salvar.Text = "Salvar";
            Btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            Btn_Editar.Location = new Point(825, 523);
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Size = new Size(75, 23);
            Btn_Editar.TabIndex = 47;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.Location = new Point(909, 523);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(75, 23);
            Btn_Excluir.TabIndex = 46;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarRaca
            // 
            Btn_BuscarRaca.Location = new Point(335, 269);
            Btn_BuscarRaca.Name = "Btn_BuscarRaca";
            Btn_BuscarRaca.Size = new Size(59, 23);
            Btn_BuscarRaca.TabIndex = 50;
            Btn_BuscarRaca.Text = "Buscar";
            Btn_BuscarRaca.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarEspecie
            // 
            Btn_BuscarEspecie.Location = new Point(335, 94);
            Btn_BuscarEspecie.Name = "Btn_BuscarEspecie";
            Btn_BuscarEspecie.Size = new Size(59, 23);
            Btn_BuscarEspecie.TabIndex = 51;
            Btn_BuscarEspecie.Text = "Buscar";
            Btn_BuscarEspecie.UseVisualStyleBackColor = true;
            // 
            // FrmEspecieRaca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 569);
            Controls.Add(Btn_BuscarEspecie);
            Controls.Add(Btn_BuscarRaca);
            Controls.Add(Btn_Sair);
            Controls.Add(Btn_Salvar);
            Controls.Add(Btn_Editar);
            Controls.Add(Btn_Excluir);
            Controls.Add(GrpBox_PesoPorIdade);
            Controls.Add(GrpBox_OBS);
            Controls.Add(CmbBox_TipoEspecie);
            Controls.Add(GrpBox_ExpecVida);
            Controls.Add(GrpBox_Temperatura);
            Controls.Add(Txt_DescRaca);
            Controls.Add(Lbl_DescRaca);
            Controls.Add(Lbl_CodRaca);
            Controls.Add(Txt_CodRaca);
            Controls.Add(Lbl_TipoEspecie);
            Controls.Add(Txt_DescEspecie);
            Controls.Add(label2);
            Controls.Add(Lbl_CodEspecie);
            Controls.Add(Txt_CodEspecie);
            Controls.Add(Lbl_Raca);
            Controls.Add(Lbl_Especie);
            Name = "FrmEspecieRaca";
            Text = "EspecieRaca";
            Load += FrmEspecieRaca_Load;
            GrpBox_Temperatura.ResumeLayout(false);
            GrpBox_Temperatura.PerformLayout();
            GrpBox_ExpecVida.ResumeLayout(false);
            GrpBox_ExpecVida.PerformLayout();
            GrpBox_OBS.ResumeLayout(false);
            GrpBox_OBS.PerformLayout();
            GrpBox_PesoPorIdade.ResumeLayout(false);
            GrpBox_PesoPorIdade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_PesoPorIdade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Especie;
        private Label Lbl_Raca;
        private TextBox Txt_CodEspecie;
        private Label Lbl_CodEspecie;
        private Label label2;
        private TextBox Txt_DescEspecie;
        private Label Lbl_TipoEspecie;
        private TextBox Txt_DescRaca;
        private Label Lbl_DescRaca;
        private Label Lbl_CodRaca;
        private TextBox Txt_CodRaca;
        private GroupBox GrpBox_Temperatura;
        private TextBox Txt_TempCorpMax;
        private Label Lbl_TempCorpMin;
        private Label Lbl_TempCorpMax;
        private TextBox Txt_TempCorpMin;
        private GroupBox GrpBox_ExpecVida;
        private TextBox Txt_ExpecVidaMax;
        private Label Lbl_ExpecVidaMin;
        private Label Lbl_ExpecVidaMax;
        private TextBox Txt_ExpecVidaMin;
        private TextBox Txt_OBS;
        private ComboBox CmbBox_TipoEspecie;
        private GroupBox GrpBox_OBS;
        private GroupBox GrpBox_PesoPorIdade;
        private DataGridView DtGridView_PesoPorIdade;
        private Button Btn_Sair;
        private Button Btn_Salvar;
        private Button Btn_Editar;
        private Button Btn_Excluir;
        private Button Btn_BuscarRaca;
        private Button Btn_BuscarEspecie;
        private Button Btn_Del;
        private Button Btn_Add;
        private Label Lbl_Faixa;
        private TextBox Txt_PesoMax;
        private TextBox Txt_PesoMin;
        private Label Lbl_PesoMax;
        private Label Lbl_PesoMin;
        private TextBox Txt_IdadeMax;
        private TextBox Txt_IdadeMin;
        private Label label1;
        private Label Lbl_IdadeMin;
        private Label Lbl_Faixa2;
    }
}