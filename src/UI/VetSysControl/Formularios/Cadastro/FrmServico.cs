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
    public partial class FrmServico : Form {
        public FrmServico() {
            InitializeComponent();
        }

        private void FrmServico_Load(object sender, EventArgs e) {
            ClearComp();
        }

        private void ClearComp() {

            Txt_Codigo.Text = string.Empty;
            Txt_Desc.Text = string.Empty;
            MskBox_Valor.Text = string.Empty;

            LstBox_Func.DataSource = null;
            LstBox_Vac.DataSource = null;
            LstBox_Insumos.DataSource = null;
        }
    }
}
