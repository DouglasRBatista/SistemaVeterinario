namespace Models.Pessoa
{
    public class Cliente : Pessoa
    {
        private string Telefone {  get; set; }
        private string Email { get; set; }

        public Cliente() : base() {
            Telefone = string.Empty;
            Email = string.Empty;
        }

        public Cliente(Pessoa pessoa) {
            IdPessoa = pessoa.GetIdPessoa();
            IdUsuario = pessoa.GetIdUsuario();
            Nome = pessoa.GetNome();
            CPF = pessoa.GetCPF();
            DtNascimento = pessoa.GetDtNascimento();
            Endereco = pessoa.GetEndereco();
        }

        public string GetTelefone() {
            return Telefone;
        }

        public void SetTelefone(string telefone) {
            this.Telefone = telefone;
        }
        public string GetEmail() {
            return Email;
        }

        public void SetEmail(string email) {
            this.Email = email;
        }
    }
}
