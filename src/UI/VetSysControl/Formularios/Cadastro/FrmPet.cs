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
    public partial class FrmPet : Form {
        public FrmPet() {
            InitializeComponent();
        }

        private void FrmPet_Load(object sender, EventArgs e) {
            ClearComp();
        }

        private void ClearComp() {
            Txt_Codigo.Text = string.Empty;
            Txt_Chip.Text = string.Empty;
            Txt_Nome.Text = string.Empty;
            Txt_Especie.Text = string.Empty;
            Txt_Raca.Text = string.Empty;
            Txt_Cliente.Text = string.Empty;
            Txt_Cor.Text = string.Empty;
            Dtp_DataNasc.Value = DateTime.Today;
            Txt_Idade.Text = string.Empty;
            PicBox_Pet.Image = null;

            RBtn_Macho.Checked = true;
            RBtn_Femea.Checked = false;

            RBtn_Sim.Checked = false;
            RBtn_Nao.Checked = true;

            DtGridView_Alergias.DataSource = null;
            DtGridView_Vacinas.DataSource = null;
        }
    }
}
