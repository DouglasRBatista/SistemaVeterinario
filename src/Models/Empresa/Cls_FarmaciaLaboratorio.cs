namespace Models.Empresa
{
    public class Cls_FarmaciaLaboratorio : Cls_Empresa
    {
        public bool FlgIntegrada {  get; set; }
        private int IdFilial { get; set; }
        public bool FlgTerceirizada { get; set; }
        private int IdTerceirizada { get; set; }
        public bool FlgFornecedor { get; set; }
        public string DescFarmLab {  get; set; }
        public string ObsFarmLab {  get; set; }

        public Cls_FarmaciaLaboratorio() : base() 
        {
            FlgIntegrada = false;
            IdFilial = 0;
            FlgTerceirizada = false;
            IdTerceirizada = 0;
            FlgFornecedor = false;
            DescFarmLab = string.Empty;
            ObsFarmLab = string.Empty;
        }

        public Cls_FarmaciaLaboratorio(Cls_Empresa empresa)
        {
            IdEmpresa = empresa.GetIdEmpresa();
            CodEmpresa = empresa.GetCodEmpresa();
            RazaoSocial = empresa.GetRazaoSocial();
            Endereco = empresa.GetEndereco();
            CNPJ = empresa.GetCNPJ();
            Telefone = empresa.GetTelefone();
            Unidade = empresa.GetUnidade();
            Logo = empresa.GetLogo();
            FlgIntegrada = false;
            IdFilial = 0;
            FlgTerceirizada = false;
            IdTerceirizada = 0;
            FlgFornecedor = false;
            DescFarmLab = string.Empty;
            ObsFarmLab = string.Empty;
        }

        public int GetIdFilial() 
        { 
            return this.IdFilial;
        }

        public void SetIdFilial(int id) 
        { 
            this.IdFilial = id;
        }

        public int GetIdTerceirizada()
        {
            return this.IdTerceirizada;
        }

        public void SetIdTerceirizada(int id)
        {
            this.IdTerceirizada = id;
        }

    }
}
