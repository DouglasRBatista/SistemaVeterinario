namespace Models.Empresa
{
    public class FarmaciaLaboratorio : Empresa
    {
        public bool FlgIntegrada {  get; set; }
        private int IdFilial { get; set; }
        public bool FlgTercerizada { get; set; }
        private int IdTercerizada { get; set; }
        public bool FlgFornecedor { get; set; }
        public string DescFarmLab {  get; set; }
        public string ObsFarmLab {  get; set; }

        public FarmaciaLaboratorio() : base() 
        {
            FlgIntegrada = false;
            IdFilial = 0;
            FlgTercerizada = false;
            IdTercerizada = 0;
            FlgFornecedor = false;
            DescFarmLab = string.Empty;
            ObsFarmLab = string.Empty;
        }

        public FarmaciaLaboratorio(Empresa empresa)
        {
            IdEmpresa = empresa.GetIdEmpresa();
            CodEmpresa = empresa.GetCodEmpresa();
            RazaoSocial = empresa.GetRazaoSocial();
            Enderco = empresa.GetEnderco();
            CNPJ = empresa.GetCNPJ();
            Telefone = empresa.GetTelefone();
            Unidade = empresa.GetUnidade();
            Logo = empresa.GetLogo();
            FlgIntegrada = false;
            IdFilial = 0;
            FlgTercerizada = false;
            IdTercerizada = 0;
            FlgFornecedor = false;
            DescFarmLab = string.Empty;
            ObsFarmLab = string.Empty;
        }

        public int GetIdFilial() 
        { 
            return IdFilial;
        }

        public void SetIdFilial(int id) 
        { 
            this.IdFilial = id;
        }

        public int GetIdTercerizada()
        {
            return IdTercerizada;
        }

        public void SetIdTercerizada(int id)
        {
            this.IdTercerizada = id;
        }

    }
}
