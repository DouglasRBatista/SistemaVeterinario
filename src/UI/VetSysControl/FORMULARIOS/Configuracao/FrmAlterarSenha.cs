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

        Bll_Usuario bll = new Bll_Usuario();
        Cls_Funcionario func = new Cls_Funcionario();


        public FrmAlterarSenha() {
            InitializeComponent();
        }

        private void FrmAlterarSenha_Load(object sender, EventArgs e) {
            ClearComp();

            bll._SqlConnectionString = configSettings.GetAppSettingsConfig("ConnectionString");

            loadUsuario();
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
                
            }
            catch (Exception ex) { 

            }
        }

        //private void SetUsuario(Cls_Funcionario funcionario) {
        //    func = funcionario;
        //}
    }
}
