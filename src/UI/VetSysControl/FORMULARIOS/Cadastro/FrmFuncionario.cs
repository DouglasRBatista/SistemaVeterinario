using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetSysControl.FORMULARIOS.Cadastro {
    public partial class FrmFuncionario : Form {
        public FrmFuncionario() {
            InitializeComponent();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e) {
            ClearComp();
        }
        private void ClearComp() {
            
            //Funcionario
            Txt_CPF.Text = string.Empty;
            Txt_Nome.Text = string.Empty;
            Txt_Endereco.Text = string.Empty;
            Dtp_DataNasc.Value = DateTime.Today;
            ChkBox_Inativo.Checked = false;

            CmbBox_Cargo.DataSource = null;
            CmbBox_Dept.DataSource = null;
            CmbBox_Emp.DataSource = null;
            ChkBox_Terceirizado.Checked = false;

            MskBox_Salario.Text = string.Empty;
            MskBox_Comissao.Text = string.Empty;

            //Veterinario
            ChkBox_AnimPortPeq.Checked = false;
            ChkBox_AnimPortGrand.Checked = false;
            ChkBox_AnimSelv.Checked = false;
            ChkBox_AnimExot.Checked = false;
            ChkBox_AnimPesqu.Checked = false;

            ChkBox_ClinCirurg.Checked = false;
            ChkBox_ProdAnim.Checked = false;
            ChkBox_Lab.Checked = false;
            ChkBox_VigilanInspec.Checked = false;
            ChkBox_Pesquisa.Checked = false;
            ChkBox_Anestesia.Checked = false;
            ChkBox_Pesquisa.Checked = false;

            LstBox_Competencia.DataSource = null;
        }
    }
}
