namespace Models.Empresa
{
    public class Filial : Empresa
    {
        private bool FlgDayCare {  get; set; }
        private decimal CsvDayCare { get; set; }
        private bool FlgUnidadeHospitalar {  get; set; }
        private decimal CsvHospital { get; set; }
        private bool FlgProntoAtendimento { get; set; }
        private decimal CsvProntoAtendimento {  set; get; }
        private bool FlgFarmacia { get; set; }
        private decimal Faturamento {  get; set; }
        private decimal Custo {  get; set; }

        public Filial() 
        {
            idEmpresa = 0;
            CodEmpresa = string.Empty;
            RazaoSocial = string.Empty;
            Enderco = string.Empty;
            CNPJ = string.Empty;
            Telefone = string.Empty;
            Unidade = string.Empty;
            Logo = string.Empty;
            FlgDayCare = false;
            CsvDayCare = 0;
            FlgUnidadeHospitalar = false;
            CsvHospital = 0;
            FlgProntoAtendimento = false;
            CsvProntoAtendimento = 0;
            FlgFarmacia = false;
            Faturamento = 0;
            Custo = 0;
        }
    }
}
