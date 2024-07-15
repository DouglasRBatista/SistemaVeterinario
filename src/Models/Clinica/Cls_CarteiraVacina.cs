using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clinica
{
    public class Cls_CarteiraVacina {
        private int IdCarteiraVac;
        private int IdPet;
        private int IdVacina;
        private string Lote;
        private DateTime DataVacina;
        private DateTime DataRenovacao;
        private int IdVeterinario;
        private int NumDose;

        public Cls_CarteiraVacina() {
            IdCarteiraVac = 0;
            IdPet = 0;
            IdVacina = 0;
            Lote = string.Empty;
            DataVacina = DateTime.MinValue;
            DataRenovacao = DateTime.MinValue;
            IdVeterinario = 0;
            NumDose = 0;
        }
        public int GetIdCarteiraVac() {
            return IdCarteiraVac;
        }

        public void SetIdCarteiraVac(int id) {
            IdCarteiraVac = id;
        }

        public int GetIdPet() {
            return IdPet;
        }

        public void SetIdPet(int id) {
            IdPet = id;
        }
        public int GetIdVacina() {
            return IdVacina;
        }

        public void SetIdVacina(int id) {
            IdVacina = id;
        }

        public string GetLote() {
            return Lote;
        }

        public void SetLote(string lote) {
            Lote = lote;
        }

        public DateTime GetDataVacina() {
            return DataVacina;
        }

        public void SetDataAtendimento(DateTime dataVac) {
            DataVacina = dataVac;
        }

        public DateTime GetDataRenovacao() {
            return DataRenovacao;
        }

        public void SetDataRenovacao(DateTime dataRenov) {
            DataRenovacao = dataRenov;
        }

        public int GetIdVeterinario() {
            return IdVeterinario;
        }

        public void SetIdVeterinario(int id) {
            IdVeterinario = id;
        }

        public int GetNumDose() {
            return NumDose;
        }

        public void SetNumDose(int doses) {
            NumDose = doses;
        }
    }
}
