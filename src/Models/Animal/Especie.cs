using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Animal
{
    public class Especie {
        public int IdEspecie { get; set; }
        public string CodEspecie { get; set; }
        public string DescEspecie { get; set; }
        public string TipoEspecie { get; set; }

        public Especie() {
            IdEspecie = 0;
            CodEspecie = String.Empty;
            DescEspecie = String.Empty;
            TipoEspecie = String.Empty;
        }
        public Especie(string codEspecie, string descespecie, string tipoEspecie){
            CodEspecie = codEspecie;
            DescEspecie = descespecie;
            TipoEspecie = tipoEspecie;
        }
    }
}
