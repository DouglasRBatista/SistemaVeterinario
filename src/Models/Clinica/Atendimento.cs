using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Models.Clinica
{
    public class Atendimento{
        public int IdAtendimento { get; set; }
        public int IdPet { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAtendimento { get; set; }
        public Decimal ValorAtendimento { get; set; }
        public int IdVeterinario { get; set; }
        public int IdCliente { get; set; }
        public List<Servico> Servico { get; set; }
        //public List<Image> Foto { get; set; }
    }
}
