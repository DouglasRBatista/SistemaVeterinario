using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Animal
{
    public class PesoIdade {
        public int IdRaca { get; set; }
        public int IdadeMin { get; set; }
        public int IdadeMax { get; set; }
        public double PesoMin { get; set; }
        public double PesoMax { get; set; }

        public PesoIdade() {
            IdRaca = 0;
            IdadeMin = 0; 
            IdadeMax = 0;
            PesoMin = 0;
            PesoMax = 0;
        }  

    }
}
