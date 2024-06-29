using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Animal
{
    public class Pet
    {
        private int IdPet { get; set; }
        private string CodPet { get; set; }
        private string Nome { get; set; }
        private int IdEspecie { get; set; }
        private int IdRaca  { get; set; }
        private DateOnly DataNasc {  get; set; }
        private int IdCliente { get; set; }
        private char Sexo { get; set; }
        private List<string> Cor { get; set; }
        //private List<Alergia> Alergias { get; set; }
        private bool Exotico { get; set; }
        private int NumChip { get; set; }
        private string Foto { get; set; }

        public Pet() {
            IdPet = 0;
            CodPet = string.Empty;
            Nome = string.Empty;
            IdEspecie = 0;
            IdRaca = 0;
            DataNasc = DateOnly.MinValue;
            IdCliente = 0;
            Sexo = char.MinValue;
            //Cor = ;
            //Alergias = ;
            Exotico = false;
            NumChip = 0;
            Foto = string.Empty;
        }




    }
}
