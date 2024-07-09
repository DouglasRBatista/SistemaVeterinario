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
    public partial class FrmEmpresa : Form {
        public FrmEmpresa() {
            InitializeComponent();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e) {
            ClearComp();
        }
        private void ClearComp() { 
        
            //Empresa
            Txt_CodEmpresa.Text = string.Empty;
            Txt_RazaoSoc.Text = string.Empty;
            Txt_Endereco.Text = string.Empty;
            MskBox_CNPJ.Text = string.Empty;
            MskBox_Telefone.Text = string.Empty;
            CmbBox_Unidade.Items.Clear();
            PicBox_Logo.Image = null;

            //Filial
            ChkBox_Filial.Checked = false;
            ChkBox_DayCare.Checked = false;
            MskBox_DayCare.Text = string.Empty;
            ChkBox_UnidHosp.Checked = false;
            MskBox_UnidHosp.Text = string.Empty;
            ChkBox_ProntoAtend.Checked = false;
            MskBox_ProntoAtend.Text = string.Empty;
            ChkBox_FarmLab.Checked = false;
            MskBox_CustosFilial.Text = string.Empty;
            MskBox_FaturamentoFilial.Text = string.Empty;

            //Contratante
            ChkBox_Contr.Checked = false;
            ChkBox_UnidIntegr.Checked = false;
            Dtp_InicioContr.Value = DateTime.Today;
            Dtp_FimContr.Value = DateTime.Today;
            LstBox_Servicos.DataSource = null;
            MskBox_CustosContr.Text = string.Empty;

            //Farmacia-Laboratorio
            ChkBox_FarmLab.Checked = false;
            ChkBox_Terceirizada.Checked = false;
            ChkBox_Integr.Checked = false;
            CmbBox_Filial.DataSource = null;
            Txt_OBS.Text = string.Empty;

        }
    }
}
