using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clinica {
    public class MedicamentoFornecedor {
        public int IdMedicamentoFornecedor {  get; set; }
        public int IdMedicamento { get; set; }
        public decimal Valor { get; set; }
        public int IdFornecedor { get; set; }

        public MedicamentoFornecedor() {
            IdMedicamentoFornecedor = 0;
            IdMedicamento = 0;
            Valor = 0;
            IdFornecedor = 0;
        }

    }
}
