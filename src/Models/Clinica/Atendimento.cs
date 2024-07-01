using Models.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Models.Clinica
{
    public class Atendimento{
        private int IdAtendimento;
        private int IdPet;
        private string Titulo;
        private string Descricao;
        private DateTime DataAtendimento;
        private decimal ValorAtendimento;
        private int IdVeterinario;
        private int IdCliente;
        public List<Servico> Servico;
        public List<String> Foto;

        public Atendimento() {
            IdAtendimento = 0;
            IdPet = 0;
            Titulo = string.Empty; 
            Descricao = string.Empty;
            DataAtendimento = DateTime.MinValue;
            ValorAtendimento = 0;
            IdVeterinario = 0;
            IdCliente = 0;
            Servico = GetServico();
            Foto = GetFoto();
        }
        
        public int GetIdAtendimento() {
            return IdAtendimento;
        }

        public void SetIdAtendimento(int id) {
            IdAtendimento = id;
        }

        public int GetIdPet() {
            return IdPet;
        }

        public void SetIdPet(int id) {
            IdPet = id;
        }

        public string GetTitulo() {
            return Titulo;
        }

        public void SetTitulo(string titulo) {
            Titulo = titulo;
        }

        public string GetDescricao() {
            return Descricao;
        }

        public void SetDescricao(string descricao) {
            Descricao = descricao;
        }

        public DateTime GetDataAtendimento() {
            return DataAtendimento;
        }

        public void SetDataAtendimento(DateTime dataAtend) {
            DataAtendimento = dataAtend;
        }

        public decimal GetValorAtendimento() {
            return ValorAtendimento;
        }

        public void SetValorAtendimento(decimal valorAtend) {
            ValorAtendimento = valorAtend;
        }

        public int GetIdVeterinario() {
            return IdVeterinario;
        }

        public void SetIdVeterinario(int id) {
            IdVeterinario = id;
        }

        public int GetIdCliente() {
            return IdCliente;
        }

        public void SetIdCliente(int id) {
            IdCliente = id;
        }

        public List<Servico> GetServico() {
            return Servico;
        }

        public List<string> GetFoto() {
            return Foto;
        }

    }
}
