using VetSysControl.FORMULARIOS.Cadastro;
using VetSysControl.FORMULARIOS.Consulta;
using VetSysControl.Configuracao;
using BLL.Empresa;
using VetSysControl.FORMULARIOS.Configuracao;
using BLL.Pessoa;
using Models.Pessoa;


namespace VetSysControl.Formularios
{
    public partial class MDI : Form {
        ConfigSystemDrawing configSystemDrawing = new ConfigSystemDrawing();
        ConfigSettings configSettings = new ConfigSettings();
        public Cls_Usuario usuario { get; set; }
        static Cls_Funcionario func = new Cls_Funcionario();
        /*
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Config.WM_WAKEUP_WINDOW)
            {
                this.WindowState = FormWindowState.Normal;
                this.TopMost = true;
            }
            base.WndProc(ref m);
        }
        */
        public MDI() {
            InitializeComponent();
            //DrawMdi();

            //Bll_Empresa bll = new Bll_Empresa();
            //bll._SqlConnectionString = configSettings.GetAppSettingsConfig("ConnectionString");
            //bll.GetEmpresa(1);

        }

        public void DrawMdi() {
            BtnAtendimentos.Invalidate();
            BtnAgendamentos.Invalidate();
            BtnClientes.Invalidate();
            BtnExames.Invalidate();
        }

        public void LoadNewForm(string froms) {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            var Childform = new Form();

            switch (froms) {
                case "FrmAtendimento":
                    FrmAtendimento frmAtend = new FrmAtendimento();
                    Childform = frmAtend;
                    Childform.Text = "Atendimentos";
                    break;
                case "FrmEspecieRaca":
                    FrmEspecieRaca frmEspRac = new FrmEspecieRaca();
                    Childform = frmEspRac;
                    Childform.Text = "Raças";
                    break;
                case "FrmMedicamento":
                    FrmMedicamento frmMed = new FrmMedicamento();
                    Childform = frmMed;
                    Childform.Text = "Medicamento";
                    break;
                case "FrmMedicamentoFornecedor":
                    FrmMedicamentoFornecedor frmMedForn = new FrmMedicamentoFornecedor();
                    Childform = frmMedForn;
                    Childform.Text = "Fornecedores";
                    break;
                case "FrmPet":
                    FrmPet frPet = new FrmPet();
                    Childform = frPet;
                    Childform.Text = "Animais / Pets";
                    break;
                case "FrmServico":
                    FrmServico frmServ = new FrmServico();
                    Childform = frmServ;
                    Childform.Text = "Serviços";
                    break;
                case "FrmVacina":
                    FrmVacina frmVac = new FrmVacina();
                    Childform = frmVac;
                    Childform.Text = "Vacinas";
                    break;
                case "FrmConsultaEmp":
                    FrmConsultaEmp frmConsultaEmp = new FrmConsultaEmp();
                    Childform = frmConsultaEmp;
                    Childform.Text = "Consulta Empresas";
                    break;
                case "FrmConsultaFun":
                    FrmConsultaFun frmConsultaFun = new FrmConsultaFun();
                    Childform = frmConsultaFun;
                    Childform.Text = "Funcionarios";
                    break;
                case "FrmConsultaPet":
                    FrmConsultaPet frmConsultaPet = new FrmConsultaPet();
                    Childform = frmConsultaPet;
                    Childform.Text = "Consulta Pets";
                    break;
                case "FrmEmpresa":
                    FrmEmpresa frmEmp = new FrmEmpresa();
                    //Form11.SetUsuario(usuario);
                    Childform = frmEmp;
                    Childform.Text = "Empresas";
                    break;
                case "FrmConsultaCli":
                    FrmConsultaCli frmConsultaCli = new FrmConsultaCli();
                    Childform = frmConsultaCli;
                    Childform.Text = "Consulta Clientes";
                    break;
                case "FrmAlterarSenha":
                    FrmAlterarSenha frmAltSenha = new FrmAlterarSenha();
                    Childform = frmAltSenha;
                    Childform.Text = "Alterar Senha";
                    break;
                case "FrmFuncionario":
                    FrmFuncionario frmFunc = new FrmFuncionario();
                    Childform = frmFunc;
                    Childform.Text = "Consulta Clientes";
                    break;
                case "FrmBD":
                    FrmConsultaFun Form15 = new FrmConsultaFun();
                    Childform = Form15;
                    Childform.Text = "Consulta Clientes";
                    break;
                default:
                    Form Form = new Form();
                    Childform = Form;
                    Childform.Text = "Janela";
                    break;

            }

            Childform.MdiParent = this;
            Childform.TopLevel = false;
            Childform.ControlBox = false;
            Childform.WindowState = FormWindowState.Maximized;
            Childform.Text = "Janela ";
            Childform.Show();
            Childform.Refresh();

        }

        #region Eventos Acao
        private void OpenFile(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e) {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        // Eventos de click

        //Cliente
        private void TsmiCadCli_Click(object sender, EventArgs e) {
            LoadNewForm("FrmCliente");
        }
        private void TsmiConsultaCli_Click(object sender, EventArgs e) {
            LoadNewForm("FrmConsultaCli");
        }

        //Pet
        private void TsmiCadPet_Click(object sender, EventArgs e) {
            LoadNewForm("FrmPet");
        }
        private void TsmiCadEspecieRaca_Click(object sender, EventArgs e) {
            LoadNewForm("FrmEspecieRaca");
        }
        private void TsmiConsultaPet_Click(object sender, EventArgs e) {
            LoadNewForm("FrmConsultaPet");
        }

        //Funcionario
        private void TsmiCadFunc_Click(object sender, EventArgs e) {
            LoadNewForm("FrmFuncionario");
        }
        private void TsmiConsultaFunc_Click(object sender, EventArgs e) {
            LoadNewForm("FrmConsultaFunc");
        }

        //Empresa
        private void TsmiCadEmpresa_Click(object sender, EventArgs e) {
            LoadNewForm("FrmEmpresa");
        }
        private void TsmiConsultaEmp_Click(object sender, EventArgs e) {
            LoadNewForm("FrmConsultaEmp");
        }
        private void TsmiCadFornecedor_Click(object sender, EventArgs e) {
            LoadNewForm("FrmMedicamentoFornecedor");
        }

        //Atendimento
        private void BtnAtendimentos_Click(object sender, EventArgs e) {
            LoadNewForm("FrmAtendimento");
        }
        private void BtnAgendamentos_Click(object sender, EventArgs e) {
            LoadNewForm("FrmConsultaEmp");
        }
        private void BtnExames_Click(object sender, EventArgs e) {
            LoadNewForm("FrmEmpresa");
        }


        //Medicamento
        private void TsmiCadMed_Click(object sender, EventArgs e) {
            LoadNewForm("FrmMedicamento");
        }
        private void TsmiCadVac_Click(object sender, EventArgs e) {
            LoadNewForm("FrmVacina");
        }
        private void TsmiCadServ_Click(object sender, EventArgs e) {
            LoadNewForm("FrmServico");
        }


        //Configurações
        private void TsmiAlterarSenha_Click(object sender, EventArgs e) {
            LoadNewForm("FrmAlterarSenha");
        }
        private void TsmiBD_Click(object sender, EventArgs e) {
            LoadNewForm("FrmBD");
        }


        #endregion Eventos Acao


        #region Eventos Design
        private void BtnClientes_Paint(object sender, PaintEventArgs e) {
            //configSystemDrawing.DrawToolStripButtonBorder(e.Graphics, this.ClientRectangle, BtnClientes);
            //configSystemDrawing.SetToolStripButtonFont(BtnClientes);
        }
        private void BtnFuncionarios_Paint(object sender, PaintEventArgs e) {
            //configSystemDrawing.DrawToolStripButtonBorder(e.Graphics, this.ClientRectangle, BtnFuncionarios);
            //configSystemDrawing.SetToolStripButtonFont(BtnFuncionarios);
        }
        private void BtnPets_Paint(object sender, PaintEventArgs e) {
            //configSystemDrawing.DrawToolStripButtonBorder(e.Graphics, this.ClientRectangle, BtnPets);
            //configSystemDrawing.SetToolStripButtonFont(BtnPets);
        }
        private void BtnAtendimentos_Paint(object sender, PaintEventArgs e) {
            //configSystemDrawing.DrawToolStripButtonBorder(e.Graphics, this.ClientRectangle, BtnAtendimentos);
            //configSystemDrawing.SetToolStripButtonFont(BtnAtendimentos);
        }
        private void BtnAgendamentos_Paint(object sender, PaintEventArgs e) {
            //configSystemDrawing.DrawToolStripButtonBorder(e.Graphics, this.ClientRectangle, BtnAgendamentos);
            //configSystemDrawing.SetToolStripButtonFont(BtnAgendamentos);
        }
        private void BtnExames_Paint(object sender, PaintEventArgs e) {
            //configSystemDrawing.DrawToolStripButtonBorder(e.Graphics, this.ClientRectangle, BtnExames);
            //configSystemDrawing.SetToolStripButtonFont(BtnExames);
        }
        private void BtnEspecieRaca_Paint(object sender, PaintEventArgs e) {
            //configSystemDrawing.DrawToolStripButtonBorder(e.Graphics, this.ClientRectangle, BtnEspecieRaca);
            //configSystemDrawing.SetToolStripButtonFont(BtnEspecieRaca);
        }
        private void BtnMedicamento_Paint(object sender, PaintEventArgs e) {
            //configSystemDrawing.DrawToolStripButtonBorder(e.Graphics, this.ClientRectangle, BtnMedicamento);
            //configSystemDrawing.SetToolStripButtonFont(BtnMedicamento);
        }
        private void BtnFornecedor_Paint(object sender, PaintEventArgs e) {
            //configSystemDrawing.DrawToolStripButtonBorder(e.Graphics, this.ClientRectangle, BtnFornecedor);
            //configSystemDrawing.SetToolStripButtonFont(BtnFornecedor);
        }
        private void BtnServico_Paint(object sender, PaintEventArgs e) {
            //configSystemDrawing.DrawToolStripButtonBorder(e.Graphics, this.ClientRectangle, BtnServico);
            //configSystemDrawing.SetToolStripButtonFont(BtnServico);
        }
        private void BtnVacinas_Paint(object sender, PaintEventArgs e) {
            //configSystemDrawing.DrawToolStripButtonBorder(e.Graphics, this.ClientRectangle, BtnVacinas);
            //configSystemDrawing.SetToolStripButtonFont(BtnVacinas);
        }
        #endregion Eventos Design


    }
}
