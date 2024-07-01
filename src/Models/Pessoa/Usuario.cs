namespace Models.Pessoa
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Login { get; set; }
        private string Senha { get; set; }
        public bool Ativo { get; set; }

        public Usuario() {
            IdUsuario = 0;
            Login = string.Empty;
            Senha = string.Empty;
            Ativo = false;
        }

        public int GetIdUsuario() {
            return IdUsuario;
        }

        public void SetLogin(string login) {
            Login = login;
        }

        public string GetSenha() {
            return Senha;
        }
        public void SetSenha(string senha) {
            Senha = senha;
        }

    }
}
