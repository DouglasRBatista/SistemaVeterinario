namespace Models.Empresa
{
    public class Empresa
    {
        protected int idEmpresa {  get; set; }
        protected string CodEmpresa { get; set; }
        protected string RazaoSocial { get; set; }
        protected string Enderco {  get; set; }
        protected string CNPJ { get; set; }
        protected string Telefone {  get; set; }
        protected string Unidade { get; set; }
        protected string Logo { get; set; }

        public Empresa() 
        {
            idEmpresa = 0;
            CodEmpresa = string.Empty;
            RazaoSocial = string.Empty;
            Enderco = string.Empty;
            CNPJ = string.Empty;
            Telefone = string.Empty;
            Unidade = string.Empty;
            Logo = string.Empty;
        }
    }
}
