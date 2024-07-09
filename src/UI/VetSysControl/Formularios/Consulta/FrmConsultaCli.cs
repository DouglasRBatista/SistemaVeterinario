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
    public partial class FrmConsultaCli : Form {
        public FrmConsultaCli() {
            InitializeComponent();
        }

        private void FrmConsultaCli_Load(object sender, EventArgs e) {
            ClearComp();
        }

        private void ClearComp() {
            Txt_CPF.Text = string.Empty;
            Txt_Nome.Text = string.Empty;
            Txt_Email.Text = string.Empty;
            MskTxt_Telefone.Text = string.Empty;
        }
    }
}
