using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetSysControl.Configuracao;
using BLL.Pessoa;
using Models.Pessoa;

namespace VetSysControl.FORMULARIOS.Configuracao {
    public partial class FrmAlterarSenha : Form {

        ConfigSystemDrawing configSystemDrawing = new ConfigSystemDrawing();
        ConfigSettings configSettings = new ConfigSettings();

        Bll_Usuario bllUsuario = new Bll_Usuario();
        Bll_Funcionario bllFunc = new Bll_Funcionario();
        Cls_Usuario usuario = new Cls_Usuario();
        Cls_Funcionario func = new Cls_Funcionario();
        bool checkOK = false;

        public FrmAlterarSenha() {
            InitializeComponent();
        }

        private void FrmAlterarSenha_Load(object sender, EventArgs e) {
            ClearComp();

            bllUsuario._SqlConnectionString = configSettings.GetAppSettingsConfig("ConnectionString");
            bllFunc._SqlConnectionString = configSettings.GetAppSettingsConfig("ConnectionString");

            loadUsuario();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e) {
            
            checkOK = CheckComp();

            if (checkOK) {
                UpdateSenha();
                MessageBox.Show("Senha Alterada!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void Btn_Sair_Click(object sender, EventArgs e) {
            Close();
        }

        private void ClearComp() {

            Txt_CPF.Text = string.Empty;
            Txt_Nome.Text = string.Empty;
            Txt_Login.Text = string.Empty;
            Txt_Senha.Text = string.Empty;
            Txt_Senha2.Text = string.Empty;
        }

        private void loadUsuario() {
            try {
                func = bllFunc.GetFuncionario(usuario.IdUsuario);

                Txt_CPF.Text = func.GetCPF();
                Txt_Nome.Text = func.GetNome();
                Txt_Login.Text = usuario.Login;

            }
            catch (Exception ex) {

            }
        }

        private bool CheckComp() {
            try {
                if (String.IsNullOrEmpty(Txt_Senha.Text) || String.IsNullOrEmpty(Txt_Senha2.Text) ||
                    String.IsNullOrWhiteSpace(Txt_Senha.Text) || String.IsNullOrWhiteSpace(Txt_Senha2.Text)) {

                    MessageBox.Show("Campos em Branco", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else {

                    if (Txt_Senha.Text != Txt_Senha2.Text) {

                        MessageBox.Show("Senhas diferentes", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else {
                        usuario.SetSenha(Txt_Senha.Text);
                        return true;
                    }
                }


            }
            catch (Exception ex) {
                return false;
            }
        }
        private void UpdateSenha() {
            try {

                bllUsuario.UpdateUsuario(usuario);

            }
            catch (Exception ex) {
            }
        }

        public void SetUsuario(Cls_Usuario us) {
            usuario = us;
        }

    }
}
