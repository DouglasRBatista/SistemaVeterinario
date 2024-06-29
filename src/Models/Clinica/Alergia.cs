using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clinica
{
    public class Alergia{

        public int IdAlergia { get; set; }
        public string CodAlergia { get; set; }
        public string NomeAlergia { get; set; }
        public string Tipo { get; set; }

        public Alergia() {
            IdAlergia = 0;
            CodAlergia = string.Empty;
            NomeAlergia= string.Empty;
            Tipo = string.Empty;
        }

    }
}
