using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Animal
{
    public class Cls_Especie {
        public int IdEspecie { get; set; }
        public string CodEspecie { get; set; }
        public string DescEspecie { get; set; }
        public string TipoEspecie { get; set; }

        public Cls_Especie() {
            IdEspecie = 0;
            CodEspecie = String.Empty;
            DescEspecie = String.Empty;
            TipoEspecie = String.Empty;
        }
        public Cls_Especie(string codEspecie, string descespecie, string tipoEspecie){
            CodEspecie = codEspecie;
            DescEspecie = descespecie;
            TipoEspecie = tipoEspecie;
        }
    }
}
