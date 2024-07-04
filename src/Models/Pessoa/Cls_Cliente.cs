namespace Models.Pessoa
{
    public class Cls_Cliente : Cls_Pessoa
    {
        private string Telefone {  get; set; }
        private string Email { get; set; }

        public Cls_Cliente() : base() {
            Telefone = string.Empty;
            Email = string.Empty;
        }

        public Cls_Cliente(Cls_Pessoa pessoa) {
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
