using BLL.Empresa;
using BLL.Pessoa;
using Models.Pessoa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetSysControl.Configuracao;

namespace VetSysControl.FORMULARIOS.Consulta {
    public partial class FrmConsultaCli : Form {

        ConfigSystemDrawing configSystemDrawing = new ConfigSystemDrawing();
        ConfigSettings configSettings = new ConfigSettings();
        Bll_Cliente bllCliente = new Bll_Cliente();

        string query = String.Empty;
        List<string> queryWHERE = new List<string>();
        bool where = false;

        public FrmConsultaCli() {
            InitializeComponent();
        }

        private void FrmConsultaCli_Load(object sender, EventArgs e) {
            ClearComp();

            bllCliente._SqlConnectionString = configSettings.GetAppSettingsConfig("ConnectionString");
            LoadAllCli();
        }

        private void Btn_Sair_Click(object sender, EventArgs e) {
            Close();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e) {
            GetQuery();
            DtGridView_Cliente.DataSource = null;
            DtGridView_Cliente.DataSource = bllCliente.SearchClientes(query);
        }
        private void ClearComp() {
            Txt_CPF.Text = string.Empty;
            Txt_Nome.Text = string.Empty;
            Txt_Email.Text = string.Empty;
            MskTxt_Telefone.Text = string.Empty;
        }

        private void LoadAllCli() {
            DtGridView_Cliente.DataSource = bllCliente.GetClientes();
        }
        private void GetQuery() {

            query = string.Empty;
            queryWHERE.Clear();

            query = "SELECT * FROM [Cliente] ";

            if (!String.IsNullOrEmpty(Txt_CPF.Text) || !String.IsNullOrWhiteSpace(Txt_CPF.Text)) {
                queryWHERE.Add(" [CPF] = '" + Txt_CPF.Text + "' ");
                where = true;
            }

            if (!String.IsNullOrEmpty(Txt_Nome.Text) || !String.IsNullOrWhiteSpace(Txt_Nome.Text)) {
                queryWHERE.Add(" [Nome] = '" + Txt_Nome.Text + "' ");
                where = true;
            }

            if (!String.IsNullOrEmpty(Txt_Email.Text) || !String.IsNullOrWhiteSpace(Txt_Email.Text)) {
                queryWHERE.Add(" [Email] = '" + Txt_Email.Text + "' ");
                where = true;
            }

            if (!String.IsNullOrEmpty(MskTxt_Telefone.Text) || !String.IsNullOrWhiteSpace(MskTxt_Telefone.Text)) {
                queryWHERE.Add(" [Telefone] = '" + MskTxt_Telefone.Text + "' ");
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
    }
}
