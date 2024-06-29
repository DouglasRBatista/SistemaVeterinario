using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clinica
{
    public class CarteiraVacina {
        private int IdCarteiraVac { get; set; }
        private int IdPet { get; set; }
        private int IdVacina { get; set; }
        private string Lote { get; set; }
        private DateOnly DataVacina { get; set; }
        private DateOnly DataRenovacao { get; set; }
        private int IdVeterinario { get; set; }
        private int NumDose { get; set; }

        public CarteiraVacina() {
            IdCarteiraVac = 0;
            IdPet = 0;
            IdVacina = 0;
            Lote = string.Empty;
            DataVacina = DateOnly.MinValue;
            DataRenovacao = DateOnly.MinValue;
            IdVeterinario = 0;
            NumDose = 0;
        }
    }
}
