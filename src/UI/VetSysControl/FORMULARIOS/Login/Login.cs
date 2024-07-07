using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Pessoa;
using Models.Pessoa;
using VetSysControl.Configuracao;
using VetSysControl.Formularios;

namespace VetSysControl.FORMULARIOS.Login {
    public partial class Login : Form {

        public List<Cls_Usuario> lst_Login = new List<Cls_Usuario>();
        public bool loginfail = false;
        ConfigSettings configSettings = new ConfigSettings();

        public Login() {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) {
            try {
                Bll_Usuario bll = new Bll_Usuario();
                bll._SqlConnectionString = configSettings.GetAppSettingsConfig("ConnectionString");
                lst_Login = bll.GetUsuarios();
            }
            catch (Exception ex) {
            }
        }
        private void Btn_Login_Click(object sender, EventArgs e) {
            Logar();
        }

        private void Txt_Login_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Logar();
            }
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Logar();
            }
        }

        private void Logar() {
            try {
                foreach (Cls_Usuario us in lst_Login) {

                    if (Txt_Login.Text == us.Login && Txt_Senha.Text == us.GetSenha() && us.Ativo == true) {
                        loginfail = true;
                        this.Hide();
                        MDI mdi = new MDI();
                        mdi.ShowDialog();
                        this.Close();
                    }
                }
                if (!loginfail) {
                    MessageBox.Show("Login e Senha incorretos!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {

            }
        }

    }
}
