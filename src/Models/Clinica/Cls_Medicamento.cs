using Models.Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Clinica
{
    public class Cls_Medicamento
    {
        public int IdMedicamento { get; set; }
        public string CodMedicamento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public int Quantidade { get; set; }
        public string Lote { get; set; }
        public DateOnly Validade { get; set; }
        public List<Cls_MedicamentoFornecedor> Valor { get; set; }
        public string Fabricante { get; set; }
        public List<Cls_FarmaciaLaboratorio> Fornecedor { get; set; }

        public Cls_Medicamento() {
            IdMedicamento = 0;
            CodMedicamento = string.Empty;
            Nome = string.Empty;
            Descricao = string.Empty;
            Tipo = string.Empty;
            Quantidade = 0;
            Lote = string.Empty;
            Validade = DateOnly.MinValue;
            Valor = GetValor();
            Fabricante = string.Empty;
            Fornecedor = GetFornecedor();
        }

        public List<Cls_MedicamentoFornecedor> GetValor() {
            return Valor;
        }

        public List<Cls_FarmaciaLaboratorio> GetFornecedor() {
            return Fornecedor;
        }
    }
}
