using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Clinica;

namespace Models.Animal
{
    public class Cls_Pet
    {
        private int IdPet;
        private string CodPet;
        private string Nome;
        private int IdEspecie;
        private int IdRaca;
        private DateTime DataNasc;
        private int IdCliente;
        private char Sexo;
        private List<string> Cor;
        private List<Cls_Alergia> Alergias;
        private bool Exotico;
        private int NumChip;
        private string Foto;

        public Cls_Pet() {
            IdPet = 0;
            CodPet = string.Empty;
            Nome = string.Empty;
            IdEspecie = 0;
            IdRaca = 0;
            DataNasc = DateTime.MinValue;
            IdCliente = 0;
            Sexo = char.MinValue;
            Cor = GetCor();
            Alergias = GetAlergias();
            Exotico = false;
            NumChip = 0;
            Foto = string.Empty;
        }

        public int GetIdPet() {
            return IdPet;
        }

        public void SetIdPet(int id) {
            IdPet = id;
        }

        public string GetCodPet() {
            return CodPet;
        }

        public void SetCodPet(string codPet) {
            CodPet = codPet;
        }

        public string GetNome() {
            return Nome;
        }

        public void SetNome(string nome) {
            Nome = nome;
        }

        public int GetIdEspecie() {
            return IdEspecie;
        }

        public void SetIdEspecie(int id) {
            IdEspecie = id;
        }

        public int GetIdRaca() {
            return IdRaca;
        }

        public void SetIdRaca(int id) {
            IdRaca = id;
        }

        public char GetSexo() {
            return Sexo;
        }

        public void SetIdRaca(char sexo) {
            Sexo = sexo;
        }

        public bool GetExotico() {
            return Exotico;
        }

        public void SetExotico(bool exotico) {
            Exotico = exotico;
        }

        public int GetNumChip() {
            return NumChip;
        }

        public void SetNumChip(int numChip) {
            NumChip = numChip;
        }

        public List<string> GetCor() {
            return Cor;
        }
        public List<Cls_Alergia> GetAlergias() {
            return Alergias;
        }
    }
}
