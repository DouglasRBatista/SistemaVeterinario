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
    public partial class FrmEspecieRaca : Form {
        public FrmEspecieRaca() {
            InitializeComponent();
        }

        private void FrmEspecieRaca_Load(object sender, EventArgs e) {
            ClearComp();
        }

        private void ClearComp() {
            
            //Especie
            Txt_CodEspecie.Text = string.Empty;
            Txt_DescEspecie.Text = string.Empty;
            CmbBox_TipoEspecie.DataSource = null;

            //Raca
            Txt_CodRaca.Text = string.Empty;
            Txt_DescRaca.Text = string.Empty;
            Txt_OBS.Text = string.Empty;

            Txt_TempCorpMin.Text = string.Empty;
            Txt_TempCorpMax.Text = string.Empty;

            Txt_ExpecVidaMin.Text = string.Empty;
            Txt_ExpecVidaMax.Text = string.Empty;

            DtGridView_PesoPorIdade.DataSource = null;
            Txt_IdadeMin.Text = string.Empty;
            Txt_IdadeMax.Text = string.Empty;
            Txt_PesoMin.Text = string.Empty;
            Txt_PesoMax.Text = string.Empty;
        }
    }
}
