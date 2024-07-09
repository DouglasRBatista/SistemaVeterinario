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
    public partial class FrmVacina : Form {
        public FrmVacina() {
            InitializeComponent();
        }
        private void Vacina_Load(object sender, EventArgs e) {

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
    }
}
