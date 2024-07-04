namespace Models.Empresa
{
    public class Cls_Filial : Cls_Empresa
    {
        public bool FlgDayCare {  get; set; }
        public decimal CsvDayCare { get; set; }
        public bool FlgUnidadeHospitalar {  get; set; }
        public decimal CsvHospital { get; set; }
        public bool FlgProntoAtendimento { get; set; }
        public decimal CsvProntoAtendimento {  set; get; }
        public bool FlgFarmacia { get; set; }
        private decimal Custo {  get; set; }

        public Cls_Filial() : base()
        {
            FlgDayCare = false;
            CsvDayCare = 0;
            FlgUnidadeHospitalar = false;
            CsvHospital = 0;
            FlgProntoAtendimento = false;
            CsvProntoAtendimento = 0;
            FlgFarmacia = false;
            Custo = CSV();
        }

        public Cls_Filial(Cls_Empresa empresa)
        {
            IdEmpresa = empresa.GetIdEmpresa();
            CodEmpresa = empresa.GetCodEmpresa();
            RazaoSocial = empresa.GetRazaoSocial();
            Endereco = empresa.GetEndereco();
            CNPJ = empresa.GetCNPJ();
            Telefone = empresa.GetTelefone();
            Unidade = empresa.GetUnidade();
            Logo = empresa.GetLogo();
            FlgDayCare = false;
            CsvDayCare = 0;
            FlgUnidadeHospitalar = false;
            CsvHospital = 0;
            FlgProntoAtendimento = false;
            CsvProntoAtendimento = 0;
            FlgFarmacia = false;
            Custo = CSV();
        }

        public decimal GetFaturamento()
        {
            // Criar Função
            return 0;
        }

        public decimal GetCusto() 
        {
            return this.Custo;
        }

        private decimal CSV()
        {
            // Criar Função
            return 0;
        }
    }
}
