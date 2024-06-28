using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Empresa
{
    public class FarmaciaLaboratorio : Empresa
    {
        private bool FlgIntegrada {  get; set; }
        private int IdFilial { get; set; }
        private bool FlgTercerizada { get; set; }
        private int IdTercerizada { get; set; }
        private bool FlgFornecedor { get; set; }
        private string DescFarmLab {  get; set; }
        private string ObsFarmLab {  get; set; }

        public FarmaciaLaboratorio() : base() 
        {
            FlgIntegrada = false;
            IdFilial = 0;
            FlgTercerizada = false;
            IdTercerizada = 0;
            FlgFornecedor = false;
            DescFarmLab = string.Empty;
            ObsFarmLab = string.Empty;
        }
    }
}
