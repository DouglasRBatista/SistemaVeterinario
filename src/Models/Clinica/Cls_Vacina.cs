using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clinica
{
    public class Cls_Vacina {
        private int IdVacina { get; set; }
        private string CodVacina{ get; set; }
        private string NomeVacina { get; set; }
        private string Descricao { get; set; }
        private string Tipo { get; set; }
        private string Fabricante { get; set; }
        private string Lote { get; set; }
        private DateOnly Validade { get; set; }
        private bool DoseUnica { get; set; }
        private int QtdDose { get; set; }
        private int Periodicidade { get; set; }
        private string UnidTempo { get; set; }


    }
}
