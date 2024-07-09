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
    public partial class FrmAtendimento : Form {
        public FrmAtendimento() {
            InitializeComponent();
        }

        private void FrmAtendimento_Load(object sender, EventArgs e) {
            ClearComp();
        }

        private void ClearComp() {
            
            //Atendimento
            Txt_Atendimento.Text = String.Empty;
            Txt_Titulo.Text = String.Empty;
            Txt_Cliente.Text = String.Empty;
            Txt_Vet.Text = String.Empty;
            Dtp_Data.Value = DateTime.Today;
            Dtp_Hora.Value = DateTime.Now;
            Txt_Desc.Text = String.Empty;
            MskTxt_Valor.Text = String.Empty;

            //Serviço
            DtGridView_Servicos.DataSource = null;

            //Pet
            Txt_Pet.Text = String.Empty;
            Txt_Especie.Text = String.Empty;
            Txt_Raca.Text = String.Empty;
            Dtp_DataNasc.Value = DateTime.Today;
            Txt_Idade.Text = String.Empty;
            RBtn_Macho.Checked = true;
            RBtn_Femea.Checked = false;
            DtGridView_Alergias.DataSource = null;
            DtGridView_Vacinas.DataSource = null;
        }
    }
}
