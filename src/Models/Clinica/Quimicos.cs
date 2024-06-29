using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clinica
{
    public class Quimicos{
        public int IdQuimico { get; set; }
        public int IdMedicamento { get; set; }
        public int UnidMed { get; set; }
        public double Dosagem { get; set; }

        public Quimicos() {
            IdQuimico = 0;
            IdMedicamento = 0;
            UnidMed = 0;
            Dosagem = 0;
        }
    }
}
