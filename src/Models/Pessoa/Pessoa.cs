namespace Models.Pessoa
{
    public class Pessoa
    {
        protected int IdPessoa { get; set; }
        protected int IdUsuarui { get; set; }
        protected string Nome { get; set; }
        protected string CPF { get; set; }
        protected DateOnly DtNacimento { get; set; }
        protected string Endereco { get; set; }

        public Pessoa()
        {
            IdPessoa = 0;
            IdUsuarui = 0;
            Nome = string.Empty;
            CPF = string.Empty;
            DtNacimento = new DateOnly();
            Endereco = string.Empty;
        }

        public int GetIdPessoa()
        {
            return this.IdPessoa;
        }

        public void SetIdPessoa(int id)
        {
            this.IdPessoa = id;
        }

        public int GetIdUsuarui()
        {
            return this.IdUsuarui;
        }

        public void SetIdUsuarui(int id)
        {
            this.IdUsuarui = id;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public string GetCPF()
        {
            return this.CPF;
        }

        public void SetCPF(string cpf)
        {
            this.CPF = cpf;
        }

        public DateOnly GetDtNacimento()
        {
            return this.DtNacimento;
        }

        public void SetDtNacimento(DateOnly data)
        {
            this.DtNacimento = data;
        }

        public string GetEndereco()
        {
            return this.Endereco;
        }

        public void SetEndereco(string endereco)
        {
            this.Endereco = endereco;
        }

    }
}
