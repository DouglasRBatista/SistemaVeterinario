using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace VetSysControl.FORMULARIOS.Cadastro {
    public partial class FrmVacina : Form {
        public FrmVacina() {
            InitializeComponent();
        }
        private void Vacina_Load(object sender, EventArgs e) {
            ClearComp();
            CRUD("Default");
            UnidadeTempo();

        }

        private void Btn_Salvar_Click(object sender, EventArgs e) {

        }

        private void Btn_Editar_Click(object sender, EventArgs e) {

        }

        private void Btn_Excluir_Click(object sender, EventArgs e) {

        }

        private void Btn_Sair_Click(object sender, EventArgs e) {
            Close();
        }

        private void ClearComp() {
            Txt_Codigo.Text = string.Empty;
            Txt_Nome.Text = string.Empty;
            Txt_Tipo.Text = string.Empty;
            Txt_Fabricante.Text = string.Empty;
            Txt_Lote.Text = string.Empty;
            Dtp_Validade.Value = DateTime.Today;
            Txt_QtdDose.Text = string.Empty;
            Txt_Periodicidade.Text = string.Empty;
            CmbBox_UnidTempo.DataSource = null;
        }


        private void CRUD(string option) {

            switch (option) {

                case "LOAD":

                    Btn_Salvar.Enabled = false;
                    Btn_Editar.Enabled = true;
                    Btn_Excluir.Enabled = true;

                    Btn_Buscar.Enabled = true;
                    Txt_Codigo.Enabled = false;
                    Txt_Nome.Enabled = false;
                    Txt_Tipo.Enabled = false;
                    Txt_Fabricante.Enabled = false;
                    Txt_Lote.Enabled = false;
                    Dtp_Validade.Enabled = false;
                    Txt_QtdDose.Enabled = false;
                    Txt_Periodicidade.Enabled = false;
                    CmbBox_UnidTempo.Enabled = false;

                    break;

                case "UPDATE":

                    Btn_Salvar.Enabled = true;
                    Btn_Editar.Enabled = false;
                    Btn_Excluir.Enabled = false;

                    Btn_Buscar.Enabled = false;
                    Txt_Codigo.Enabled = true;
                    Txt_Nome.Enabled = true;
                    Txt_Tipo.Enabled = true;
                    Txt_Fabricante.Enabled = true;
                    Txt_Lote.Enabled = true;
                    Dtp_Validade.Enabled = true;
                    Txt_QtdDose.Enabled = true;
                    Txt_Periodicidade.Enabled = true;
                    CmbBox_UnidTempo.Enabled = true;
                    break;

                case "DELETE":

                    Btn_Salvar.Enabled = false;
                    Btn_Editar.Enabled = false;
                    Btn_Excluir.Enabled = false;
                    break;

                default:

                    Btn_Salvar.Enabled = true;
                    Btn_Editar.Enabled = false;
                    Btn_Excluir.Enabled = false;

                    Btn_Buscar.Enabled = true;
                    Txt_Codigo.Enabled = true;
                    Txt_Nome.Enabled = true;
                    Txt_Tipo.Enabled = true;
                    Txt_Fabricante.Enabled = true;
                    Txt_Lote.Enabled = true;
                    Dtp_Validade.Enabled = true;
                    Txt_QtdDose.Enabled = true;
                    Txt_Periodicidade.Enabled = true;
                    CmbBox_UnidTempo.Enabled = true;
                    break;
            }

        }

        private void UnidadeTempo() {

            CmbBox_UnidTempo.Items.AddRange(["Dia", "Mês", "Ano"]);

        }

    }
}
