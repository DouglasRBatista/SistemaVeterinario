using BLL.Empresa;
using Models.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetSysControl.Configuracao;
using VetSysControl.FORMULARIOS.Cadastro;
using static System.Net.Mime.MediaTypeNames;

namespace VetSysControl.FORMULARIOS.Consulta {
    public partial class FrmConsultaEmp : Form {

        ConfigSystemDrawing configSystemDrawing = new ConfigSystemDrawing();
        ConfigSettings configSettings = new ConfigSettings();
        Bll_Empresa bllEmpresa = new Bll_Empresa();

        List<Cls_Empresa> lst_Empresas = new List<Cls_Empresa>();
        Cls_Empresa empresa = new Cls_Empresa();
        string query;
        string cnpj;
        int Id;
        bool where = false;
        List<string> queryWHERE = new List<string>();

        public FrmConsultaEmp() {
            InitializeComponent();
        }

        private void FrmConsultaCli_Load(object sender, EventArgs e) {
            ClearComp();

            bllEmpresa._SqlConnectionString = configSettings.GetAppSettingsConfig("ConnectionString");
            LoadAllEmp();
        }

        private void DtGridView_Empresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            DataGridViewRow linha = DtGridView_Empresa.Rows[e.RowIndex];
            Id = Convert.ToInt32(linha.Cells["IdEmpresa"].Value);
            FrmEmpresa frmEmpresa = new FrmEmpresa();
            frmEmpresa.IdEmpresa(Id);
            frmEmpresa.loadEmpresa();
            this.Hide();
            frmEmpresa.Show();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e) {
            GetQuery();
            DtGridView_Empresa.DataSource = null;
            DtGridView_Empresa.DataSource = bllEmpresa.SearchEmpresas(query);
        }

        private void Btn_Sair_Click(object sender, EventArgs e) {
            Close();
        }

        private void ClearComp() {
            Txt_Codigo.Text = string.Empty;
            Txt_RazaoSocial.Text = string.Empty;
            MskBox_CNPJ.Text = string.Empty;
            MskBox_Telefone.Text = string.Empty;
        }
        private void LoadAllEmp() {
            DtGridView_Empresa.DataSource = bllEmpresa.GetEmpresas();
        }

        private void GetQuery() {
            
            query = string.Empty;
            queryWHERE.Clear();

            query = "SELECT * FROM [Empresa] ";

            if (!String.IsNullOrEmpty(Txt_Codigo.Text) || !String.IsNullOrWhiteSpace(Txt_Codigo.Text)) {
                queryWHERE.Add(" [CodEmpresa] = \"" + Txt_Codigo.Text + "\" ");
                where = true;
            }

            if (!String.IsNullOrEmpty(Txt_RazaoSocial.Text) || !String.IsNullOrWhiteSpace(Txt_RazaoSocial.Text)) {
                queryWHERE.Add(" [RazaoSocial] \"= " + Txt_RazaoSocial.Text + "\" ");
                where = true;
            }

            if (!String.IsNullOrEmpty(MskBox_CNPJ.Text) || !String.IsNullOrWhiteSpace(MskBox_CNPJ.Text)) {
                cnpj = RemoveCNPKMask(MskBox_CNPJ.Text);
                if (!String.IsNullOrEmpty(cnpj) || !String.IsNullOrWhiteSpace(cnpj)) {
                    queryWHERE.Add(" [CNPJ] = \"" + MskBox_CNPJ.Text + "\" ");
                    where = true;
                }
            }

            if (!String.IsNullOrEmpty(MskBox_Telefone.Text) || !String.IsNullOrWhiteSpace(MskBox_Telefone.Text)) {
                queryWHERE.Add(" [Telefone] = \"" + MskBox_Telefone.Text + "\" ");
                where = true;
            }

            if (where) {
                query += "WHERE ";

                for (int i = 0; i < queryWHERE.Count; i++) {
                    query += queryWHERE[i];
                    if (i < queryWHERE.Count - 1)
                        query += " AND ";
                }
            }
        }

        private string RemoveCNPKMask(string cnpj) {
            const string regex = "[^0-9]";
            return Regex.Replace(cnpj, regex, "");
        }
    }
}
