namespace Models.Empresa
{
    public class Cls_Empresa
    {
        protected int IdEmpresa { get; set; }
        protected string CodEmpresa { get; set; }
        protected string RazaoSocial { get; set; }
        protected string Endereco { get; set; }
        protected string CNPJ { get; set; }
        protected string Telefone { get; set; }
        protected string Unidade { get; set; }
        protected string Tipo { get; set; }
        protected string Logo { get; set; }

        public Cls_Empresa() 
        {
            IdEmpresa = 0;
            CodEmpresa = string.Empty;
            RazaoSocial = string.Empty;
            Endereco = string.Empty;
            CNPJ = string.Empty;
            Telefone = string.Empty;
            Unidade = string.Empty;
            Tipo = string.Empty;
            Logo = string.Empty;
        }

        public int GetIdEmpresa()
        {
            return this.IdEmpresa;
        }

        public void SetIdEmpresa(int idEmpresa) 
        {
            this.IdEmpresa = idEmpresa;
        }

        public string GetCodEmpresa()
        {
            return this.CodEmpresa;
        }

        public void SetCodEmpresa(string codEmpresa)
        {
            this.CodEmpresa = codEmpresa;
        }

        public string GetRazaoSocial()
        {
            return this.RazaoSocial;
        }

        public void SetRazaoSocial(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
        }

        public string GetEndereco()
        {
            return this.Endereco;
        }

        public void SetEndereco(string endereco)
        {
            this.Endereco = endereco;
        }

        public string GetCNPJ()
        {
            return this.CNPJ;
        }

        public void SetCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
        }

        public string GetTelefone()
        {
            return this.Telefone;
        }

        public void SetTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public string GetUnidade()
        {
            return this.Unidade;
        }

        public void SetUnidade(string unidade)
        {
            this.Unidade = unidade;
        }

        public string GetTipo() {
            return this.Tipo;
        }

        public void SetTipo(string tipo) {
            this.Tipo = tipo;
        }

        public string GetLogo()
        {
            return this.Logo;
        }

        public void SetLogo(string logo)
        {
            this.Logo = logo;
        }

    }
}
