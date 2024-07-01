using Models.Clinica;

namespace Models.Empresa
{
    public class Contratante : Empresa
    {
        public DateTime InicioContrato { get; private set; }
        public DateTime FimContrato { get; private set; }
        public List<Servico> Servicos { get; set; }
        private decimal CsvFinal { get; set; }
        public bool UnidadeIntegrada { get; set; }

        public Contratante() : base()
        {
            InicioContrato = DateTime.MinValue;
            FimContrato = DateTime.MinValue;
            Servicos = null;
            CsvFinal = 0;
            UnidadeIntegrada = false;
        }

        public Contratante(Empresa empresa)
        {
            IdEmpresa = empresa.GetIdEmpresa();
            CodEmpresa = empresa.GetCodEmpresa();
            RazaoSocial = empresa.GetRazaoSocial();
            Endereco = empresa.GetEndereco();
            CNPJ = empresa.GetCNPJ();
            Telefone = empresa.GetTelefone();
            Unidade = empresa.GetUnidade();
            Logo = empresa.GetLogo();
            InicioContrato = DateTime.MinValue;
            FimContrato = DateTime.MinValue;
            Servicos = null;
            CsvFinal = 0;
            UnidadeIntegrada = false;
        }

        public void SetInicioContrato(DateTime data) 
        { 
            this.InicioContrato = data;
        }

        public void SetFimContrato(DateTime data) 
        { 
            this.FimContrato = data;
        }

        public decimal GetCsvFinal() 
        {
            return this.CsvFinal;
        }

        public void SetCsvFinal(decimal csv) 
        {  
            this.CsvFinal = csv; 
        }

    }
}
