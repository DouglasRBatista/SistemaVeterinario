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
            Lbl_CadastroAtend = new Label();
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
            // Atendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl_CadastroAtend);
            Name = "Atendimento";
            Text = "Atendimento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_CadastroAtend;
    }
}