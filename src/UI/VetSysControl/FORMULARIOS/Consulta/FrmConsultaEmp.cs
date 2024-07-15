using BLL.Empresa;
using Models.Empresa;
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
using VetSysControl.FORMULARIOS.Cadastro;

namespace VetSysControl.FORMULARIOS.Consulta {
    public partial class FrmConsultaEmp : Form {

        ConfigSystemDrawing configSystemDrawing = new ConfigSystemDrawing();
        ConfigSettings configSettings = new ConfigSettings();
        Bll_Empresa bllEmpresa = new Bll_Empresa();

        List<Cls_Empresa> lst_Empresas = new List<Cls_Empresa>();
        Cls_Empresa empresa = new Cls_Empresa();

        int Id;

        public FrmConsultaEmp() {
            InitializeComponent();
        }

        private void FrmConsultaCli_Load(object sender, EventArgs e) {
            ClearComp();

            bllEmpresa._SqlConnectionString = configSettings.GetAppSettingsConfig("ConnectionString");
            LoadAllEmp();
        }

        private void Btn_Sair_Click(object sender, EventArgs e) {
            Close();
        }

        private void ClearComp() {
            Txt_Codigo.Text = string.Empty;
            Txt_RazaoSocial.Text = string.Empty;
            MskBox_CNPJ.Text = string.Empty;
            MskTxt_Telefone.Text = string.Empty;
        }
        private void LoadAllEmp() {
            DtGridView_Empresa.DataSource = bllEmpresa.GetEmpresas();
        }

        private void DtGridView_Empresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            DataGridViewRow linha = DtGridView_Empresa.Rows[e.RowIndex];
            Id = Convert.ToInt32(linha.Cells["IdEmpresa"].Value);
            FrmEmpresa frmEmpresa = new FrmEmpresa();
            frmEmpresa.Id = Id;
            frmEmpresa.loadEmpresa();
            this.Hide();
            frmEmpresa.Show();
        }
    }
}
