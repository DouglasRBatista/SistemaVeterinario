using BLL.Empresa;
using BLL.Pessoa;
using Models.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetSysControl.Configuracao;
using VetSysControl.FORMULARIOS.Consulta;

namespace VetSysControl.FORMULARIOS.Cadastro {
    public partial class FrmEmpresa : Form {


        ConfigSystemDrawing configSystemDrawing = new ConfigSystemDrawing();
        ConfigSettings configSettings = new ConfigSettings();
        Cls_Empresa emp = new Cls_Empresa();
        Bll_Empresa bllEmpresa = new Bll_Empresa();
        public int idEmpresa { get; set; }

        public FrmEmpresa() {
            InitializeComponent();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e) {
            ClearComp();
            CRUD("default");
            bllEmpresa._SqlConnectionString = configSettings.GetAppSettingsConfig("ConnectionString");

        }

        private void Btn_Salvar_Click(object sender, EventArgs e) {
            CRUD("fdsfdsf");
        }
        private void Btn_Editar_Click(object sender, EventArgs e) {
            CRUD("UPDATE");
        }
        private void Btn_Excluir_Click(object sender, EventArgs e) {
            CRUD("DELETE");
        }
        private void Btn_Sair_Click(object sender, EventArgs e) {
            Close();
        }

        private void Btn_BuscarEmpresa_Click(object sender, EventArgs e) {
            FrmConsultaEmp frmConsEmp = new FrmConsultaEmp();
            frmConsEmp.Show();
        }
        private void ClearComp() {

            //Empresa
            Txt_CodEmpresa.Text = string.Empty;
            Txt_RazaoSoc.Text = string.Empty;
            Txt_Endereco.Text = string.Empty;
            MskBox_CNPJ.Text = string.Empty;
            MskBox_Telefone.Text = string.Empty;
            CmbBox_Unidade.Items.Clear();
            PicBox_Logo.Image = null;

            //Filial
            ChkBox_Filial.Checked = false;
            ChkBox_DayCare.Checked = false;
            MskBox_DayCare.Text = string.Empty;
            ChkBox_UnidHosp.Checked = false;
            MskBox_UnidHosp.Text = string.Empty;
            ChkBox_ProntoAtend.Checked = false;
            MskBox_ProntoAtend.Text = string.Empty;
            ChkBox_FarmLab.Checked = false;
            MskBox_CustosFilial.Text = string.Empty;
            MskBox_FaturamentoFilial.Text = string.Empty;

            //Contratante
            ChkBox_Contr.Checked = false;
            ChkBox_UnidIntegr.Checked = false;
            Dtp_InicioContr.Value = DateTime.Today;
            Dtp_FimContr.Value = DateTime.Today;
            LstBox_Servicos.DataSource = null;
            MskBox_CustosContr.Text = string.Empty;

            //Farmacia-Laboratorio
            ChkBox_FarmLab.Checked = false;
            ChkBox_Terceirizada.Checked = false;
            ChkBox_Integr.Checked = false;
            CmbBox_Filial.DataSource = null;
            Txt_OBS.Text = string.Empty;

        }

        public void loadEmpresa() {
            try {
                bllEmpresa._SqlConnectionString = configSettings.GetAppSettingsConfig("ConnectionString");

                emp = bllEmpresa.GetEmpresa(idEmpresa);

                Txt_CodEmpresa.Text = emp.GetCodEmpresa();
                Txt_RazaoSoc.Text = emp.GetRazaoSocial();
                Txt_RazaoSoc.Text = emp.GetRazaoSocial();

            }
            catch (Exception ex) {

            }
        }

        private void CRUD(string option) {

            switch (option) {

                case "LOAD":

                    Btn_Salvar.Enabled = false;
                    Btn_Editar.Enabled = true;
                    Btn_Excluir.Enabled = true;

                    //Empresa
                    Btn_BuscarEmpresa.Enabled = false;
                    Txt_CodEmpresa.Enabled = false;
                    Txt_RazaoSoc.Enabled = false;
                    Txt_Endereco.Enabled = false;
                    MskBox_CNPJ.Enabled = false;
                    MskBox_Telefone.Enabled = false;
                    CmbBox_Unidade.Enabled = false;

                    //Filial
                    ChkBox_Filial.Enabled = false;
                    ChkBox_DayCare.Enabled = false;
                    MskBox_DayCare.Enabled = false;
                    ChkBox_UnidHosp.Enabled = false;
                    MskBox_UnidHosp.Enabled = false;
                    ChkBox_ProntoAtend.Enabled = false;
                    MskBox_ProntoAtend.Enabled = false;
                    ChkBox_Farmacia.Enabled = false;
                    MskBox_CustosFilial.Enabled = false;
                    MskBox_FaturamentoFilial.Enabled = false;

                    //Contratante
                    ChkBox_Contr.Enabled = false;
                    ChkBox_UnidIntegr.Enabled = false;
                    Dtp_InicioContr.Enabled = false;
                    Dtp_FimContr.Enabled = false;
                    LstBox_Servicos.Enabled = false;
                    Btn_AddServico.Enabled = false;
                    Btn_DelServico.Enabled = false;
                    MskBox_CustosContr.Enabled = false;

                    //Farmacia - Laboratorio
                    ChkBox_FarmLab.Enabled = false;
                    ChkBox_Terceirizada.Enabled = false;
                    ChkBox_Integr.Enabled = false;
                    CmbBox_Filial.Enabled = false;
                    Txt_Desc.Enabled = false;
                    Txt_OBS.Enabled = false;
                    break;

                case "UPDATE":

                    Btn_Salvar.Enabled = true;
                    Btn_Editar.Enabled = false;
                    Btn_Excluir.Enabled = false;

                    //Empresa
                    Btn_BuscarEmpresa.Enabled = false;
                    Txt_CodEmpresa.Enabled = true;
                    Txt_RazaoSoc.Enabled = true;
                    Txt_Endereco.Enabled = true;
                    MskBox_CNPJ.Enabled = true;
                    MskBox_Telefone.Enabled = true;
                    CmbBox_Unidade.Enabled = true;

                    //Filial
                    ChkBox_Filial.Enabled = true;
                    ChkBox_DayCare.Enabled = true;
                    MskBox_DayCare.Enabled = true;
                    ChkBox_UnidHosp.Enabled = true;
                    MskBox_UnidHosp.Enabled = true;
                    ChkBox_ProntoAtend.Enabled = true;
                    MskBox_ProntoAtend.Enabled = true;
                    ChkBox_Farmacia.Enabled = true;
                    MskBox_CustosFilial.Enabled = true;
                    MskBox_FaturamentoFilial.Enabled = true;

                    //Contratante
                    ChkBox_Contr.Enabled = true;
                    ChkBox_UnidIntegr.Enabled = true;
                    Dtp_InicioContr.Enabled = true;
                    Dtp_FimContr.Enabled = true;
                    LstBox_Servicos.Enabled = true;
                    Btn_AddServico.Enabled = true;
                    Btn_DelServico.Enabled = true;
                    MskBox_CustosContr.Enabled = true;

                    //Farmacia - Laboratorio
                    ChkBox_FarmLab.Enabled = true;
                    ChkBox_Terceirizada.Enabled = true;
                    ChkBox_Integr.Enabled = true;
                    CmbBox_Filial.Enabled = true;
                    Txt_Desc.Enabled = true;
                    Txt_OBS.Enabled = true;
                    break;

                case "DELETE":

                    Btn_Salvar.Enabled = false;
                    Btn_Editar.Enabled = false;
                    Btn_Excluir.Enabled = false;
                    break;

                default:

                    Btn_Salvar.Enabled = true;
                    Btn_Editar.Enabled = false;
                    Btn_Excluir.Enabled = false;

                    //Empresa
                    Btn_BuscarEmpresa.Enabled = true;
                    Txt_CodEmpresa.Enabled = true;
                    Txt_RazaoSoc.Enabled = true;
                    Txt_Endereco.Enabled = true;
                    MskBox_CNPJ.Enabled = true;
                    MskBox_Telefone.Enabled = true;
                    CmbBox_Unidade.Enabled = true;

                    //Filial
                    ChkBox_Filial.Enabled = true;
                    ChkBox_DayCare.Enabled = false;
                    MskBox_DayCare.Enabled = false;
                    ChkBox_UnidHosp.Enabled = false;
                    MskBox_UnidHosp.Enabled = false;
                    ChkBox_ProntoAtend.Enabled = false;
                    MskBox_ProntoAtend.Enabled = false;
                    ChkBox_Farmacia.Enabled = false;
                    MskBox_CustosFilial.Enabled = false;
                    MskBox_FaturamentoFilial.Enabled = false;

                    //Contratante
                    ChkBox_Contr.Enabled = true;
                    ChkBox_UnidIntegr.Enabled = false;
                    Dtp_InicioContr.Enabled = false;
                    Dtp_FimContr.Enabled = false;
                    LstBox_Servicos.Enabled = false;
                    Btn_AddServico.Enabled = false;
                    Btn_DelServico.Enabled = false;
                    MskBox_CustosContr.Enabled = false;

                    //Farmacia - Laboratorio
                    ChkBox_FarmLab.Enabled = true;
                    ChkBox_Terceirizada.Enabled = false;
                    ChkBox_Integr.Enabled = false;
                    CmbBox_Filial.Enabled = false;
                    Txt_Desc.Enabled = false;
                    Txt_OBS.Enabled = false;
                    break;
            }

        }

        public void IdEmpresa(int id) {
            idEmpresa = id;
        }
    }
}
