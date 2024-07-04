using Models.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clinica
{
    public class Cls_Servico{
        public int IdServico { get; set; }
        public string CodServico { get; set; }
        public string DescServico { get; set; }
        public List<Cls_Veterinario> Responsavel{ get; set; }
        public List<Cls_Medicamento> Insumos { get; set; }
        public List<Cls_Vacina> Vacinas { get; set; }
        public decimal ValorServico { get; set; }

       public Cls_Servico() {
            IdServico = 0;
            CodServico = string.Empty;
            DescServico = string.Empty;
            Responsavel = GetResponsavel();
            Insumos = GetInsumos();
            Vacinas = GetVacinas();
            ValorServico = 0;
        }

        public List<Cls_Veterinario> GetResponsavel() {
            return Responsavel;
        }

        public List<Cls_Medicamento> GetInsumos() {
            return Insumos;
        }

        public List<Cls_Vacina> GetVacinas() {
            return Vacinas;
        }
    }
}
