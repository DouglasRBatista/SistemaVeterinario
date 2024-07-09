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
    public partial class FrmMedicamento : Form {
        public FrmMedicamento() {
            InitializeComponent();
        }

        private void FrmMedicamento_Load(object sender, EventArgs e) {
            ClearComp();
        }

        private void ClearComp() {

            //Medicamentos
            Txt_Codigo.Text = string.Empty;
            Txt_Nome.Text = string.Empty;
            Txt_Tipo.Text = string.Empty;
            Txt_Fabricante.Text = string.Empty;
            Txt_Desc.Text = string.Empty;

            //Fornecedor
            CmbBox_Fornecedor.DataSource = null;
            Txt_Lote.Text = string.Empty;
            Txt_Qtd.Text = string.Empty;
            MskBox_Valor.Text = string.Empty;
            Dtp_Validade.Value = DateTime.Today;

            //Quimicos
            DtGridView_Quimicos.DataSource = null;
            Txt_Compostos.Text = string.Empty;
            Txt_Dosagem.Text = string.Empty;
            Txt_UnidMed.Text = string.Empty;

        }
    }
}
