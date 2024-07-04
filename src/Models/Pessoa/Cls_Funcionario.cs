namespace Models.Pessoa
{
    public class Cls_Funcionario : Cls_Pessoa
    {
        protected string Cargo { get; set; }
        protected string Departamento { get; set; }
        protected bool FlgSalario { get; set; }
        protected decimal Salario { get; set; }
        protected bool FlgComissao { get; set; }
        protected decimal Comissao { get; set; }
        protected bool FlgTerceirizado { get; set; }
        protected bool FlgInativo { get; set; }
        protected int IdEmpresa { get; set; }

        public Cls_Funcionario() : base()
        {
            Cargo = string.Empty;
            Departamento = string.Empty;
            FlgSalario = false;
            Salario = 0;
            FlgComissao = false;
            Comissao = 0;
            FlgTerceirizado = false;
            FlgInativo = false;
            IdEmpresa = 0;
        }

        public Cls_Funcionario(Cls_Pessoa pessoa)
        {
            IdPessoa = pessoa.GetIdPessoa();
            IdUsuario = pessoa.GetIdUsuario();
            Nome = pessoa.GetNome();
            CPF = pessoa.GetCPF();
            DtNascimento = pessoa.GetDtNascimento();
            Endereco = pessoa.GetEndereco();

            Cargo = string.Empty;
            Departamento = string.Empty;
            FlgSalario = false;
            Salario = 0;
            FlgComissao = false;
            Comissao = 0;
            FlgTerceirizado = false;
            FlgInativo = false;
            IdEmpresa = 0;
        }

        public string GetCargo()
        {
            return this.Cargo;
        }

        public void SetCargo(string cargo)
        {
            this.Cargo = cargo;
        }

        public string GetDepartamento()
        {
            return this.Departamento;
        }

        public void SetDepartamento(string departamento)
        {
            this.Departamento = departamento;
        }

        public bool GetFlgSalario()
        {
            return this.FlgSalario;
        }

        public void SetFlgSalario(bool flgSalario)
        {
            this.FlgSalario = flgSalario;
        }

        public decimal GetSalario()
        {
            return this.Salario;
        }

        public void SetSalario(decimal salario)
        {
            this.Salario = salario;
        }

        public bool GetFlgComissao()
        {
            return this.FlgComissao;
        }

        public void SetFlgComissao(bool flgComissao)
        {
            this.FlgComissao = flgComissao;
        }

        public decimal GetComissao()
        {
            return this.Comissao;
        }

        public void SetComissao(decimal comissao)
        {
            this.Comissao = comissao;
        }

        public bool GetFlgTerceirizado()
        {
            return this.FlgTerceirizado;
        }

        public void SetFlgTerceirizado(bool flgTerceirizado)
        {
            this.FlgTerceirizado = flgTerceirizado;
        }

        public bool GetFlgInativo()
        {
            return this.FlgInativo;
        }

        public void SetFlgInativo(bool flgInativo)
        {
            this.FlgInativo = flgInativo;
        }

        public int GetIdEmpresa()
        {
            return this.IdEmpresa;
        }

        public void SetIdEmpresa(int idEmpresa)
        {
            this.IdEmpresa = idEmpresa;
        }

    }
}
