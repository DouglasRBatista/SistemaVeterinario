namespace Models.Pessoa
{
    public class Cls_Pessoa
    {
        protected int IdPessoa { get; set; }
        protected int IdUsuario { get; set; }
        protected string Nome { get; set; }
        protected string CPF { get; set; }
        protected DateTime DtNascimento { get; set; }
        protected string Endereco { get; set; }

        public Cls_Pessoa()
        {
            IdPessoa = 0;
            IdUsuario = 0;
            Nome = string.Empty;
            CPF = string.Empty;
            DtNascimento = DateTime.MinValue;
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

        public int GetIdUsuario()
        {
            return this.IdUsuario;
        }

        public void SetIdUsuario(int id)
        {
            this.IdUsuario = id;
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

        public DateTime GetDtNascimento()
        {
            return this.DtNascimento;
        }

        public void SetDtNascimento(DateTime data)
        {
            this.DtNascimento = data;
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
