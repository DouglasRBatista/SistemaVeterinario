namespace VetSysControl.FORMULARIOS.Configuracao {
    partial class FrmAlterarSenha {
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
            Lbl_Nome = new Label();
            Txt_Nome = new TextBox();
            Lbl_CPF = new Label();
            Txt_CPF = new TextBox();
            Btn_Sair = new Button();
            BtnConfirmar = new Button();
            GrpBox_Login = new GroupBox();
            Lbl_Senha2 = new Label();
            Txt_Senha2 = new TextBox();
            Lbl_Senha = new Label();
            Txt_Senha = new TextBox();
            Lbl_Login = new Label();
            Txt_Login = new TextBox();
            GrpBox_Login.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.Location = new Point(27, 60);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(43, 15);
            Lbl_Nome.TabIndex = 80;
            Lbl_Nome.Text = "Nome:";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(79, 57);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(329, 23);
            Txt_Nome.TabIndex = 79;
            // 
            // Lbl_CPF
            // 
            Lbl_CPF.AutoSize = true;
            Lbl_CPF.Location = new Point(27, 32);
            Lbl_CPF.Name = "Lbl_CPF";
            Lbl_CPF.Size = new Size(31, 15);
            Lbl_CPF.TabIndex = 78;
            Lbl_CPF.Text = "CPF:";
            // 
            // Txt_CPF
            // 
            Txt_CPF.Location = new Point(79, 29);
            Txt_CPF.Name = "Txt_CPF";
            Txt_CPF.Size = new Size(131, 23);
            Txt_CPF.TabIndex = 77;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(333, 294);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 81;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(243, 294);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(75, 23);
            BtnConfirmar.TabIndex = 82;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // GrpBox_Login
            // 
            GrpBox_Login.Controls.Add(Lbl_Senha2);
            GrpBox_Login.Controls.Add(Txt_Senha2);
            GrpBox_Login.Controls.Add(Lbl_Senha);
            GrpBox_Login.Controls.Add(Txt_Senha);
            GrpBox_Login.Controls.Add(Lbl_Login);
            GrpBox_Login.Controls.Add(Txt_Login);
            GrpBox_Login.Location = new Point(27, 86);
            GrpBox_Login.Name = "GrpBox_Login";
            GrpBox_Login.Size = new Size(381, 202);
            GrpBox_Login.TabIndex = 83;
            GrpBox_Login.TabStop = false;
            GrpBox_Login.Text = "Login";
            // 
            // Lbl_Senha2
            // 
            Lbl_Senha2.AutoSize = true;
            Lbl_Senha2.Location = new Point(89, 133);
            Lbl_Senha2.Name = "Lbl_Senha2";
            Lbl_Senha2.Size = new Size(104, 15);
            Lbl_Senha2.TabIndex = 84;
            Lbl_Senha2.Text = "Confirme a Senha:";
            // 
            // Txt_Senha2
            // 
            Txt_Senha2.Location = new Point(89, 151);
            Txt_Senha2.Name = "Txt_Senha2";
            Txt_Senha2.Size = new Size(213, 23);
            Txt_Senha2.TabIndex = 83;
            Txt_Senha2.UseSystemPasswordChar = true;
            // 
            // Lbl_Senha
            // 
            Lbl_Senha.AutoSize = true;
            Lbl_Senha.Location = new Point(89, 79);
            Lbl_Senha.Name = "Lbl_Senha";
            Lbl_Senha.Size = new Size(42, 15);
            Lbl_Senha.TabIndex = 82;
            Lbl_Senha.Text = "Senha:";
            // 
            // Txt_Senha
            // 
            Txt_Senha.Location = new Point(89, 97);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.Size = new Size(213, 23);
            Txt_Senha.TabIndex = 81;
            Txt_Senha.UseSystemPasswordChar = true;
            // 
            // Lbl_Login
            // 
            Lbl_Login.AutoSize = true;
            Lbl_Login.Location = new Point(89, 29);
            Lbl_Login.Name = "Lbl_Login";
            Lbl_Login.Size = new Size(40, 15);
            Lbl_Login.TabIndex = 80;
            Lbl_Login.Text = "Login:";
            // 
            // Txt_Login
            // 
            Txt_Login.Location = new Point(89, 48);
            Txt_Login.Name = "Txt_Login";
            Txt_Login.Size = new Size(213, 23);
            Txt_Login.TabIndex = 79;
            // 
            // FrmAlterarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 329);
            Controls.Add(GrpBox_Login);
            Controls.Add(BtnConfirmar);
            Controls.Add(Btn_Sair);
            Controls.Add(Lbl_Nome);
            Controls.Add(Txt_Nome);
            Controls.Add(Lbl_CPF);
            Controls.Add(Txt_CPF);
            Name = "FrmAlterarSenha";
            Text = "FrmAlterarSenha";
            GrpBox_Login.ResumeLayout(false);
            GrpBox_Login.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Nome;
        private TextBox Txt_Nome;
        private Label Lbl_CPF;
        private TextBox Txt_CPF;
        private Button Btn_Sair;
        private Button BtnConfirmar;
        private GroupBox GrpBox_Login;
        private Label Lbl_Senha;
        private TextBox Txt_Senha;
        private Label Lbl_Login;
        private TextBox Txt_Login;
        private Label Lbl_Senha2;
        private TextBox Txt_Senha2;
    }
}