using BLL.Empresa;
using BLL.Pessoa;
using Models.Clinica;
using Models.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetSysControl.Configuracao;
using VetSysControl.FORMULARIOS.Consulta;

namespace VetSysControl.FORMULARIOS.Cadastro {
    public partial class FrmEmpresa : Form {


        ConfigSystemDrawing configSystemDrawing = new ConfigSystemDrawing();
        ConfigSettings configSettings = new ConfigSettings();

        Cls_Empresa emp = new Cls_Empresa();
        Cls_Filial filial = new Cls_Filial();
        Cls_Contratante contratante = new Cls_Contratante();
        Cls_FarmaciaLaboratorio farmLab = new Cls_FarmaciaLaboratorio();
        List<Cls_Servico> lstServ = new List<Cls_Servico>();

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
            if (ValidateComp() == false) {
                SetEmpresa();
                bllEmpresa.SetEmpresa(emp);
                emp = bllEmpresa.GetEmpresa(emp);
                if (emp.GetTipo() != "") {
                    if (emp.GetTipo() == "Filial") {
                        //bllEmpresa.SetFilial(emp);
                    }else if(emp.GetTipo() == "Contratante") {
                        //bllEmpresa.SetContratante(emp);
                    }
                    else if (emp.GetTipo() == "Farmácia - Laboratório") {
                        //bllEmpresa.SetFarmLab(emp);
                    }
                }
                CRUD("LOAD");
            }
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
        private void ChkBox_Filial_CheckedChanged(object sender, EventArgs e) {
            EnableComp(ChkBox_Filial);
        }

        private void ChkBox_Contr_CheckedChanged(object sender, EventArgs e) {
            EnableComp(ChkBox_Contr);
        }

        private void ChkBox_FarmLab_CheckedChanged(object sender, EventArgs e) {
            EnableComp(ChkBox_FarmLab);
        }

        private void Btn_AddServico_Click(object sender, EventArgs e) {

        }
        private void Btn_DelServico_Click(object sender, EventArgs e) {
            if (LstBox_Servicos.SelectedIndex >= 0)
                LstBox_Servicos.Items.RemoveAt(LstBox_Servicos.SelectedIndex);
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
                    if (emp.GetTipo() == "Filial") {

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

                    }
                    //Contratante
                    else if (emp.GetTipo() == "Contratante") {
                        ChkBox_Contr.Enabled = true;
                        ChkBox_UnidIntegr.Enabled = true;
                        Dtp_InicioContr.Enabled = true;
                        Dtp_FimContr.Enabled = true;
                        LstBox_Servicos.Enabled = true;
                        Btn_AddServico.Enabled = true;
                        Btn_DelServico.Enabled = true;
                        MskBox_CustosContr.Enabled = true;
                    }
                    //Farmacia - Laboratorio
                    else if (emp.GetTipo() == "Farmácia - Laboratório") {
                        ChkBox_FarmLab.Enabled = true;
                        ChkBox_Terceirizada.Enabled = true;
                        ChkBox_Integr.Enabled = true;
                        CmbBox_Filial.Enabled = true;
                        Txt_Desc.Enabled = true;
                        Txt_OBS.Enabled = true;
                    }
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
                    Lbl_CustosFilial.Enabled = false;
                    MskBox_CustosFilial.Enabled = false;
                    Lbl_FaturamentoFilial.Enabled = false;
                    MskBox_FaturamentoFilial.Enabled = false;

                    //Contratante
                    ChkBox_Contr.Enabled = true;
                    ChkBox_UnidIntegr.Enabled = false;
                    Lbl_InicioContr.Enabled = false;
                    Dtp_InicioContr.Enabled = false;
                    Lbl_FimContr.Enabled = false;
                    Dtp_FimContr.Enabled = false;
                    Lbl_Servicos.Enabled = false;
                    LstBox_Servicos.Enabled = false;
                    Btn_AddServico.Enabled = false;
                    Btn_DelServico.Enabled = false;
                    Lbl_CustosContr.Enabled = false;
                    MskBox_CustosContr.Enabled = false;

                    //Farmacia - Laboratorio
                    ChkBox_FarmLab.Enabled = true;
                    ChkBox_Terceirizada.Enabled = false;
                    ChkBox_Integr.Enabled = false;
                    Lbl_Filial.Enabled = false;
                    CmbBox_Filial.Enabled = false;
                    Lbl_DescFarmLab.Enabled = false;
                    Txt_Desc.Enabled = false;
                    Lbl_OBS.Enabled = false;
                    Txt_OBS.Enabled = false;
                    break;
            }

        }

        public void IdEmpresa(int id) {
            idEmpresa = id;
        }


        private bool ValidateComp() {

            bool erro = false;
            try {
                //Empresa
                if (string.IsNullOrEmpty(Txt_CodEmpresa.Text) || string.IsNullOrWhiteSpace(Txt_CodEmpresa.Text)) { erro = true; }
                if (string.IsNullOrEmpty(Txt_RazaoSoc.Text) || string.IsNullOrWhiteSpace(Txt_RazaoSoc.Text)) { erro = true; }
                if (string.IsNullOrEmpty(MskBox_CNPJ.Text) || string.IsNullOrWhiteSpace(MskBox_CNPJ.Text)) { erro = true; }
                if (string.IsNullOrEmpty(MskBox_Telefone.Text) || string.IsNullOrWhiteSpace(MskBox_Telefone.Text)) { erro = true; }
                if (string.IsNullOrEmpty(CmbBox_Unidade.Text) || string.IsNullOrWhiteSpace(CmbBox_Unidade.Text)) { erro = true; }

                //Filial
                if (ChkBox_Filial.Checked) {
                    if (ChkBox_DayCare.Checked)
                        if (string.IsNullOrEmpty(MskBox_DayCare.Text) || string.IsNullOrWhiteSpace(MskBox_DayCare.Text)) { erro = true; }

                    if (ChkBox_UnidHosp.Checked)
                        if (string.IsNullOrEmpty(MskBox_UnidHosp.Text) || string.IsNullOrWhiteSpace(MskBox_UnidHosp.Text)) { erro = true; }

                    if (ChkBox_ProntoAtend.Checked)
                        if (string.IsNullOrEmpty(MskBox_ProntoAtend.Text) || string.IsNullOrWhiteSpace(MskBox_ProntoAtend.Text)) { erro = true; }

                }

                //Contratante
                if (ChkBox_Contr.Checked) {
                    if (Dtp_InicioContr.Value < Dtp_InicioContr.MinDate) { Dtp_InicioContr.Value = DateTime.Now; }
                    if (Dtp_FimContr.Value < Dtp_FimContr.MinDate) { Dtp_FimContr.Value = DateTime.Now; }
                    if (Dtp_FimContr.Value < Dtp_InicioContr.MinDate) { Dtp_FimContr.Value = Dtp_InicioContr.Value.AddDays(+1); }
                    if (LstBox_Servicos.Items.Count > 0) { }
                    else{ 
                        erro = true; 
                    }
                }
                //Farmacia - Laboratorio
                if (ChkBox_FarmLab.Checked) {
                    if (string.IsNullOrEmpty(CmbBox_Filial.Text) || string.IsNullOrWhiteSpace(CmbBox_Filial.Text)) { erro = true; }
                    if (string.IsNullOrEmpty(Txt_Desc.Text) || string.IsNullOrWhiteSpace(Txt_Desc.Text)) { erro = true; }
                }

                return erro;
            }
            catch {
                return false;
            }
        }

        private void SetEmpresa() {
            try {
                emp.SetCodEmpresa(Txt_CodEmpresa.Text);
                emp.SetRazaoSocial(Txt_RazaoSoc.Text);
                emp.SetEndereco(Txt_Endereco.Text);
                emp.SetCNPJ(RemoveCNPJMask(MskBox_CNPJ.Text));
                emp.SetTelefone(MskBox_Telefone.Text);
                emp.SetUnidade(CmbBox_Unidade.Text);
                emp.SetLogo(PicBox_Logo.ImageLocation);

                if (ChkBox_Filial.Checked) {
                    emp.SetTipo(ChkBox_Filial.Text);

                    filial.FlgDayCare = ChkBox_DayCare.Checked;
                    filial.CsvDayCare = Convert.ToDecimal(MskBox_DayCare.Text);
                    filial.FlgUnidadeHospitalar = ChkBox_UnidHosp.Checked;
                    filial.CsvHospital = Convert.ToDecimal(MskBox_UnidHosp.Text);
                    filial.FlgProntoAtendimento = ChkBox_ProntoAtend.Checked;
                    filial.CsvProntoAtendimento = Convert.ToDecimal(MskBox_ProntoAtend.Text);
                    filial.FlgFarmacia= ChkBox_Farmacia.Checked;
                    //filial.Custos;

                }
                else if (ChkBox_Contr.Checked) {
                    emp.SetTipo(ChkBox_Contr.Text);

                    contratante.SetInicioContrato(Dtp_InicioContr.Value);
                    contratante.SetFimContrato(Dtp_FimContr.Value);
                    foreach(Cls_Servico serv in lstServ) {
                        contratante.Servicos.Add(serv);
                    }
                    contratante.SetCsvFinal(Convert.ToDecimal(MskBox_CustosContr.Text));
                    contratante.UnidadeIntegrada = ChkBox_UnidIntegr.Checked;

                }
                else if (ChkBox_FarmLab.Checked) {
                    emp.SetTipo(ChkBox_FarmLab.Text);

                    farmLab.FlgTerceirizada = ChkBox_Terceirizada.Checked;
                    farmLab.FlgIntegrada = ChkBox_Integr.Checked;
                    farmLab.DescFarmLab = Txt_Desc.Text;
                    farmLab.ObsFarmLab = Txt_OBS.Text;
                }
            }
            catch { 
            }
        }

        private void EnableComp(System.Windows.Forms.CheckBox chk) {
            if (chk.Checked) {
                switch (chk.Text) {
                    case "Filial":

                        ChkBox_Filial.Checked = true;
                        ChkBox_DayCare.Enabled = true;
                        MskBox_DayCare.Enabled = true;
                        ChkBox_UnidHosp.Enabled = true;
                        MskBox_UnidHosp.Enabled = true;
                        ChkBox_ProntoAtend.Enabled = true;
                        MskBox_ProntoAtend.Enabled = true;
                        ChkBox_Farmacia.Enabled = true;
                        Lbl_CustosFilial.Enabled = true;
                        MskBox_CustosFilial.Enabled = true;
                        Lbl_FaturamentoFilial.Enabled = true;
                        MskBox_FaturamentoFilial.Enabled = true;

                        ChkBox_Contr.Checked = false;
                        ChkBox_UnidIntegr.Enabled = false;
                        Lbl_InicioContr.Enabled = false;
                        Dtp_InicioContr.Enabled = false;
                        Lbl_FimContr.Enabled = false;
                        Dtp_FimContr.Enabled = false;
                        Lbl_Servicos.Enabled = false;
                        LstBox_Servicos.Enabled = false;
                        Btn_AddServico.Enabled = false;
                        Btn_DelServico.Enabled = false;
                        Lbl_CustosContr.Enabled = false;
                        MskBox_CustosContr.Enabled = false;

                        ChkBox_FarmLab.Checked = false;
                        ChkBox_Terceirizada.Enabled = false;
                        ChkBox_Integr.Enabled = false;
                        Lbl_Filial.Enabled = false;
                        CmbBox_Filial.Enabled = false;
                        Lbl_DescFarmLab.Enabled = false;
                        Txt_Desc.Enabled = false;
                        Lbl_OBS.Enabled = false;
                        Txt_OBS.Enabled = false;
                        break;
                    case "Contratante":

                        ChkBox_Contr.Checked = true;
                        ChkBox_UnidIntegr.Enabled = true;
                        Lbl_InicioContr.Enabled = true;
                        Dtp_InicioContr.Enabled = true;
                        Lbl_FimContr.Enabled = true;
                        Dtp_FimContr.Enabled = true;
                        Lbl_Servicos.Enabled = true;
                        LstBox_Servicos.Enabled = true;
                        Btn_AddServico.Enabled = true;
                        Btn_DelServico.Enabled = true;
                        Lbl_CustosContr.Enabled = true;
                        MskBox_CustosContr.Enabled = true;

                        ChkBox_Filial.Checked = false;
                        ChkBox_DayCare.Enabled = false;
                        MskBox_DayCare.Enabled = false;
                        ChkBox_UnidHosp.Enabled = false;
                        MskBox_UnidHosp.Enabled = false;
                        ChkBox_ProntoAtend.Enabled = false;
                        MskBox_ProntoAtend.Enabled = false;
                        ChkBox_Farmacia.Enabled = false;
                        Lbl_CustosFilial.Enabled = false;
                        MskBox_CustosFilial.Enabled = false;
                        Lbl_FaturamentoFilial.Enabled = false;
                        MskBox_FaturamentoFilial.Enabled = false;

                        ChkBox_FarmLab.Checked = false;
                        ChkBox_Terceirizada.Enabled = false;
                        ChkBox_Integr.Enabled = false;
                        Lbl_Filial.Enabled = false;
                        CmbBox_Filial.Enabled = false;
                        Lbl_DescFarmLab.Enabled = false;
                        Txt_Desc.Enabled = false;
                        Lbl_OBS.Enabled = false;
                        Txt_OBS.Enabled = false;
                        break;
                    case "Farmácia - Laboratório":

                        ChkBox_FarmLab.Checked = true;
                        ChkBox_Terceirizada.Enabled = true;
                        ChkBox_Integr.Enabled = true;
                        Lbl_Filial.Enabled = true;
                        CmbBox_Filial.Enabled = true;
                        Lbl_DescFarmLab.Enabled = true;
                        Txt_Desc.Enabled = true;
                        Lbl_OBS.Enabled = true;
                        Txt_OBS.Enabled = true;

                        ChkBox_Contr.Checked = false;
                        ChkBox_UnidIntegr.Enabled = false;
                        Lbl_InicioContr.Enabled = false;
                        Dtp_InicioContr.Enabled = false;
                        Lbl_FimContr.Enabled = false;
                        Dtp_FimContr.Enabled = false;
                        Lbl_Servicos.Enabled = false;
                        LstBox_Servicos.Enabled = false;
                        Btn_AddServico.Enabled = false;
                        Btn_DelServico.Enabled = false;
                        Lbl_CustosContr.Enabled = false;
                        MskBox_CustosContr.Enabled = false;

                        ChkBox_Filial.Checked = false;
                        ChkBox_DayCare.Enabled = false;
                        MskBox_DayCare.Enabled = false;
                        ChkBox_UnidHosp.Enabled = false;
                        MskBox_UnidHosp.Enabled = false;
                        ChkBox_ProntoAtend.Enabled = false;
                        MskBox_ProntoAtend.Enabled = false;
                        ChkBox_Farmacia.Enabled = false;
                        Lbl_CustosFilial.Enabled = false;
                        MskBox_CustosFilial.Enabled = false;
                        Lbl_FaturamentoFilial.Enabled = false;
                        MskBox_FaturamentoFilial.Enabled = false;

                        break;
                }
            }
            else {
                switch (chk.Text) {
                    case "Filial":

                        ChkBox_Filial.Checked = false;
                        ChkBox_DayCare.Enabled = false;
                        MskBox_DayCare.Enabled = false;
                        ChkBox_UnidHosp.Enabled = false;
                        MskBox_UnidHosp.Enabled = false;
                        ChkBox_ProntoAtend.Enabled = false;
                        MskBox_ProntoAtend.Enabled = false;
                        ChkBox_Farmacia.Enabled = false;
                        Lbl_CustosFilial.Enabled = false;
                        MskBox_CustosFilial.Enabled = false;
                        Lbl_FaturamentoFilial.Enabled = false;
                        MskBox_FaturamentoFilial.Enabled = false;

                        break;
                    case "Contratante":

                        ChkBox_Contr.Checked = false;
                        ChkBox_UnidIntegr.Enabled = false;
                        Lbl_InicioContr.Enabled = false;
                        Dtp_InicioContr.Enabled = false;
                        Lbl_FimContr.Enabled = false;
                        Dtp_FimContr.Enabled = false;
                        Lbl_Servicos.Enabled = false;
                        LstBox_Servicos.Enabled = false;
                        Btn_AddServico.Enabled = false;
                        Btn_DelServico.Enabled = false;
                        Lbl_CustosContr.Enabled = false;
                        MskBox_CustosContr.Enabled = false;

                        break;
                    case "Farmácia - Laboratório":

                        ChkBox_FarmLab.Checked = false;
                        ChkBox_Terceirizada.Enabled = false;
                        ChkBox_Integr.Enabled = false;
                        Lbl_Filial.Enabled = false;
                        CmbBox_Filial.Enabled = false;
                        Lbl_DescFarmLab.Enabled = false;
                        Txt_Desc.Enabled = false;
                        Lbl_OBS.Enabled = false;
                        Txt_OBS.Enabled = false;

                        break;
                }
            }

        }
        private string RemoveCNPJMask(string cnpj) {
            const string regex = "[^0-9]";
            return Regex.Replace(cnpj, regex, "");
        }

    }
}
