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
    public partial class FrmMedicamentoFornecedor : Form {
        public FrmMedicamentoFornecedor() {
            InitializeComponent();
        }

        private void FrmMedicamentoFornecedor_Load(object sender, EventArgs e) {
            ClearComp();
        }

        private void ClearComp() {
            Txt_Codigo.Text = string.Empty;
            Txt_Nome.Text = string.Empty;
            CmbBox_Fornecedor.DataSource = null;
            Txt_Lote.Text = string.Empty;
            Txt_Qtd.Text = string.Empty;
            Dtp_Validade.Value = DateTime.Today;
            MskBox_Valor.Text = string.Empty;
        }
    }
}
