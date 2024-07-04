using Models.Animal;

namespace Models.Pessoa
{
    public class Cls_Veterinario : Cls_Funcionario
    {
        public bool FlgAtAniPequenoPorte { get; set; }
        public bool FlgAtAniGrandePorte { get; set; }
        public bool FlgAtAniExoticos { get; set; }
        public bool FlgAtAniSelvagem { get; set; }
        public bool FlgAtAniPesquisa { get; set; }
        public bool FlgFunClinicaCirurgica { get; set; }
        public bool FlgFunProducaoAnimal { get; set; }
        public bool FlgFunLaboratorial { get; set; }
        public bool FlgFunVigilanciaInspecao { get; set; }
        public bool FlgFunAnestesia { get; set; }
        public bool FlgFunFarmaciaVeterinaria { get; set; }
        public bool FlgFunPesquisa { get; set; }
        public List<Cls_Raca> RacasCompetentes { get; set; }

        public Cls_Veterinario() : base() 
        {
            FlgAtAniPequenoPorte = false;
            FlgAtAniGrandePorte = false;
            FlgAtAniExoticos = false;
            FlgAtAniSelvagem = false;
            FlgAtAniPesquisa = false;
            FlgFunClinicaCirurgica = false;
            FlgFunProducaoAnimal = false;
            FlgFunLaboratorial = false;
            FlgFunVigilanciaInspecao = false;
            FlgFunAnestesia = false;
            FlgFunFarmaciaVeterinaria = false;
            FlgFunPesquisa = false;
            RacasCompetentes = GetRacasCompetentes();
        }

        public Cls_Veterinario(Cls_Funcionario funcionario)
        {
            IdPessoa = funcionario.GetIdPessoa();
            IdUsuario = funcionario.GetIdUsuario();
            Nome = funcionario.GetNome();
            CPF = funcionario.GetCPF();
            DtNascimento = funcionario.GetDtNascimento();
            Endereco = funcionario.GetEndereco();

            Cargo = funcionario.GetCargo();
            Departamento = funcionario.GetDepartamento();
            FlgSalario = funcionario.GetFlgSalario();
            Salario = funcionario.GetSalario();
            FlgComissao = funcionario.GetFlgComissao();
            Comissao = funcionario.GetComissao();
            FlgTerceirizado = funcionario.GetFlgTerceirizado();
            FlgInativo = funcionario.GetFlgInativo();
            IdEmpresa = funcionario.GetIdEmpresa();

            FlgAtAniPequenoPorte = false;
            FlgAtAniGrandePorte = false;
            FlgAtAniExoticos = false;
            FlgAtAniSelvagem = false;
            FlgAtAniPesquisa = false;
            FlgFunClinicaCirurgica = false;
            FlgFunProducaoAnimal = false;
            FlgFunLaboratorial = false;
            FlgFunVigilanciaInspecao = false;
            FlgFunAnestesia = false;
            FlgFunFarmaciaVeterinaria = false;
            FlgFunPesquisa = false;
            RacasCompetentes = GetRacasCompetentes();
        }

        public List<Cls_Raca> GetRacasCompetentes() 
        {
            // Criar Função
            return null;
        }
    }
}
