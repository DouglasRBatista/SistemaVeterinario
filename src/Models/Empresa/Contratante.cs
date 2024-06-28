using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Empresa
{
    public class Contratante : Empresa
    {
        private DateTime InicioContrato { get; set; }
        private DateTime FimContrato { get; set; }
        //private List<Servico> Servicos { get; set; }
        private Decimal CsvFinal { get; set; }
        private bool UnidadeIntegrada { get; set; }

        public Contratante() : base()
        {
            InicioContrato = DateTime.MinValue;
            FimContrato = DateTime.MinValue;
            //Servicos = null;
            CsvFinal = 0;
            UnidadeIntegrada = false;
        }
    }
}
