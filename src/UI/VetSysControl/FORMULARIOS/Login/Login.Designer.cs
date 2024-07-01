namespace VetSysControl.FORMULARIOS.Login {
    partial class Login {
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
            Lbl_Login = new Label();
            Lbl_Senha = new Label();
            Btn_Login = new Button();
            Txt_Login = new TextBox();
            Txt_Senha = new TextBox();
            Lbl_VetSysControl = new Label();
            SuspendLayout();
            // 
            // Lbl_Login
            // 
            Lbl_Login.AutoSize = true;
            Lbl_Login.Location = new Point(277, 161);
            Lbl_Login.Name = "Lbl_Login";
            Lbl_Login.Size = new Size(37, 15);
            Lbl_Login.TabIndex = 0;
            Lbl_Login.Text = "Login";
            // 
            // Lbl_Senha
            // 
            Lbl_Senha.AutoSize = true;
            Lbl_Senha.Location = new Point(277, 205);
            Lbl_Senha.Name = "Lbl_Senha";
            Lbl_Senha.Size = new Size(39, 15);
            Lbl_Senha.TabIndex = 1;
            Lbl_Senha.Text = "Senha";
            // 
            // Btn_Login
            // 
            Btn_Login.Location = new Point(354, 273);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(75, 23);
            Btn_Login.TabIndex = 2;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = true;
            // 
            // Txt_Login
            // 
            Txt_Login.Location = new Point(277, 179);
            Txt_Login.Name = "Txt_Login";
            Txt_Login.Size = new Size(220, 23);
            Txt_Login.TabIndex = 3;
            // 
            // Txt_Senha
            // 
            Txt_Senha.Location = new Point(277, 223);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.Size = new Size(220, 23);
            Txt_Senha.TabIndex = 4;
            Txt_Senha.UseSystemPasswordChar = true;
            // 
            // Lbl_VetSysControl
            // 
            Lbl_VetSysControl.AutoSize = true;
            Lbl_VetSysControl.Location = new Point(349, 79);
            Lbl_VetSysControl.Name = "Lbl_VetSysControl";
            Lbl_VetSysControl.Size = new Size(80, 15);
            Lbl_VetSysControl.TabIndex = 5;
            Lbl_VetSysControl.Text = "VetSysControl";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 450);
            Controls.Add(Lbl_VetSysControl);
            Controls.Add(Txt_Senha);
            Controls.Add(Txt_Login);
            Controls.Add(Btn_Login);
            Controls.Add(Lbl_Senha);
            Controls.Add(Lbl_Login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Login;
        private Label Lbl_Senha;
        private Button Btn_Login;
        private TextBox Txt_Login;
        private TextBox Txt_Senha;
        private Label Lbl_VetSysControl;
    }
}