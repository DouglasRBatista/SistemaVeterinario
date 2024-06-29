using Models.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clinica
{
    public class Servico{
        public int IdServico { get; set; }
        public string CodServico { get; set; }
        public string DescServico { get; set; }
        public List<Veterinario> Responsavel{ get; set; }
        public List<Medicamento> Insumos { get; set; }
        public List<Vacina> Vacinas { get; set; }
        public Decimal ValorServico { get; set; }

       public Servico() {
            IdServico = 0;
            CodServico = string.Empty;
            DescServico = string.Empty;
            //Responsavel = ;
            //Insumos = ;
            //Vacinas = ;
            ValorServico = 0;
        }
    }
}
