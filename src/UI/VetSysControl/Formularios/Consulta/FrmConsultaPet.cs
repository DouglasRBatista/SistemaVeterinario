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
    public partial class FrmConsultaPet : Form {
        public FrmConsultaPet() {
            InitializeComponent();
        }

        private void FrmConsultaPet_Load(object sender, EventArgs e) {
            ClearComp();
        }

        private void ClearComp() { 

            Txt_Codigo.Text = string.Empty;
            Txt_Nome.Text = string.Empty;
            Txt_Chip.Text = string.Empty;
            Txt_Cliente.Text = string.Empty;
            Txt_Especie.Text = string.Empty;
            Txt_Raca.Text = string.Empty;
            Txt_Tipo.Text = string.Empty;
        }
    }
}
