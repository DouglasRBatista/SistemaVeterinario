using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clinica
{
    public class Cls_Vacina {
        public int IdVacina { get; set; }
        public string CodVacina{ get; set; }
        public string NomeVacina { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Fabricante { get; set; }
        public string Lote { get; set; }
        public DateOnly Validade { get; set; }
        public bool DoseUnica { get; set; }
        public int QtdDose { get; set; }
        public int Periodicidade { get; set; }
        public string UnidTempo { get; set; }


    }
}
