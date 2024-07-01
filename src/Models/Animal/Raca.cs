using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Animal
{
    public class Raca {
        public int IdRaca { get; set; }
        public int IdEspecie { get; set; }
        public string CodRaca { get; set; }
        public string DescRaca { get; set; }
        public double TempCorpMin { get; set; }
        public double TempCorpMax { get; set; }
        public List<PesoIdade> PesoPorIdade { get; set; }
        public int EspectativaDeVidaMin { get; set; }
        public int EspectativaDeVidaMax { get; set; }
        public string ObsRaca { get; set; }

        public Raca() {
            IdRaca = 0;
            IdEspecie = 0;
            CodRaca = String.Empty;
            DescRaca = String.Empty;
            TempCorpMin = 0;
            TempCorpMax = 0;
            PesoPorIdade = GetPesoPorIdade();
            EspectativaDeVidaMin = 0;
            EspectativaDeVidaMax = 0;
            ObsRaca = String.Empty;
        }
        
        public List<PesoIdade> GetPesoPorIdade() {
            return PesoPorIdade;
        }
    }
}
