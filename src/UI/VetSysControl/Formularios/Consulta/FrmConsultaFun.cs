using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetSysControl.FORMULARIOS.Consulta {
    public partial class FrmConsultaFun : Form {
        public FrmConsultaFun() {
            InitializeComponent();
        }

        private void FrmConsultaFun_Load(object sender, EventArgs e) {
            ClearComp();
        }

        private void ClearComp() { 

            //Funcionario
            Txt_CPF.Text = string.Empty;
            Txt_Nome.Text = string.Empty;
            CmbBox_Cargo.DataSource = null;
            CmbBox_Dept.DataSource = null;
            CmbBox_Emp.DataSource = null;

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
            ChkBox_Farmac.Checked = false;
            ChkBox_Anestesia.Checked = false;
            ChkBox_Pesquisa.Checked = false;

            RBtn_SimTerceirizado.Checked = false;
            RBtn_NaoTerceirizado.Checked = false;

            RBtn_SimInativo.Checked = false;
            RBtn_NaoInativo.Checked = false;

        }
    }
}
