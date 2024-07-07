---- CREATE DATABASE
IF DB_ID('VetSysControl') IS NULL
BEGIN
	CREATE DATABASE VetSysControl;
END
GO

IF DB_ID('VetSysControl') IS NOT NULL
BEGIN
	USE VetSysControl;
END
GO

---- DROP TABLE

DROP TABLE IF EXISTS dbo.AtendimentoServico;
DROP TABLE IF EXISTS dbo.AtendimentoFoto;
DROP TABLE IF EXISTS dbo.Atendimento;

DROP TABLE IF EXISTS dbo.AlergiaPet;
DROP TABLE IF EXISTS dbo.Alergia;

DROP TABLE IF EXISTS dbo.ServicoVacinas;
DROP TABLE IF EXISTS dbo.CarteiraVacina;
DROP TABLE IF EXISTS dbo.Vacina;

DROP TABLE IF EXISTS dbo.PesoIdade;
DROP TABLE IF EXISTS dbo.Pet;
DROP TABLE IF EXISTS dbo.Raca;
DROP TABLE IF EXISTS dbo.Especie;

DROP TABLE IF EXISTS dbo.ContratanteServico;
DROP TABLE IF EXISTS dbo.ServicoInsumos;
DROP TABLE IF EXISTS dbo.ServicoResp;
DROP TABLE IF EXISTS dbo.Servico;

DROP TABLE IF EXISTS dbo.MedicamentoFornecedor;
DROP TABLE IF EXISTS dbo.ValorMedicamento;
DROP TABLE IF EXISTS dbo.Quimicos;
DROP TABLE IF EXISTS dbo.Medicamento;

DROP TABLE IF EXISTS dbo.VeterinarioCompetencias;
DROP TABLE IF EXISTS dbo.Veterinario;
DROP TABLE IF EXISTS dbo.Funcionario;
DROP TABLE IF EXISTS dbo.Cliente;
DROP TABLE IF EXISTS dbo.Pessoa;

DROP TABLE IF EXISTS dbo.Filial;
DROP TABLE IF EXISTS dbo.Contratante;
DROP TABLE IF EXISTS dbo.FarmaciaLaboratorio;
DROP TABLE IF EXISTS dbo.Empresa;

DROP TABLE IF EXISTS dbo.Usuario;

---- Usuario

CREATE TABLE Usuario(
	IdUsuario INT PRIMARY KEY IDENTITY(1,1),
	Login NVARCHAR(15),
	Senha NVARCHAR(15),
	Ativo BIT
);
GO

---- Empresa

CREATE TABLE Empresa(
	IdEmpresa INT PRIMARY KEY IDENTITY(1,1),
	CodEmpresa NVARCHAR(20),
	RazaoSocial NVARCHAR(100),
	Endereco NVARCHAR(100),
	CNPJ NVARCHAR(14),
	Telefone NVARCHAR(15),
	Unidade NVARCHAR(20),
	Logo NVARCHAR(150)
);
GO

CREATE TABLE Filial(
	IdFilial INT PRIMARY KEY,
	DayCare BIT,
	CsvDayCare DECIMAL,
	UnidadeHospitalar BIT,
	CsvUnidadeHospitalar DECIMAL,
	ProntoAtendimento BIT,
	CsvProntoAtendimento DECIMAL,
	Farmacia BIT,
	Custos DECIMAL
);
GO

CREATE TABLE Contratante(
	IdContratante INT PRIMARY KEY,
	InicioContrato Date,
	FimContrato Date,
	CsvFinal DECIMAL,
	UnidadeIntegrada BIT,
);
GO

CREATE TABLE FarmaciaLaboratorio(
	IdFarmaciaLab INT PRIMARY KEY,
	FlgIntegrada BIT,
	IdFilial INT,
	FlgFornecedor BIT, -- Se TRUE = A farmácia produz seus medicamentos / Se FALSE = importam de outro local
	DescFarmLab NVARCHAR(50),
	ObsFarmLab NVARCHAR(MAX),
);
GO

---- Pessoa

CREATE TABLE Pessoa(
	IdPessoa INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	Nome NVARCHAR(60),
	CPF NVARCHAR(14) UNIQUE,
	DtNascimento Date,
	Endereco NVARCHAR(100),
	CONSTRAINT FK_Pessoa_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario) ON DELETE CASCADE
);
GO

CREATE TABLE Cliente(
	IdCliente INT PRIMARY KEY,
	IdUsuario INT,
	Telefone NVARCHAR(15),
	Email NVARCHAR(50),
	CONSTRAINT FK_Cli_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario) ON DELETE CASCADE
);
GO

CREATE TABLE Funcionario(
	IdFuncionario INT PRIMARY KEY,
	IdUsuario INT,
	Cargo NVARCHAR(20),
	Departamento NVARCHAR(20),
	FlgSalario BIT,
	Salario DECIMAL,
	FlgComissao BIT,
	Comissao DECIMAL,
	FlgTerceirizado BIT,
	IdEmpresa INT,
	Inativo BIT,
	CONSTRAINT FK_Func_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario) ON DELETE CASCADE,
	CONSTRAINT FK_Func_Emp FOREIGN KEY (IdEmpresa) REFERENCES Empresa(IdEmpresa) ON DELETE CASCADE
);
GO

CREATE TABLE Veterinario(
	IdVeterinario INT,
	FlgAtAniPequenoPorte BIT,
	FlgAtAniGrandePorte BIT,
	FlgAtAniExoticos BIT,
	FlgAtAniSelvagem BIT,
	FlgAtAniPesquisa BIT,
	FlgFunClinicaCirurgica BIT,
	FlgFunProducaoAnimal BIT,
	FlgFunLaboratorial BIT,
	FlgFunVigilanciaInspecao BIT,
	FlgFunAnestesia BIT,
	FlgFunFarmaciaVeterinaria BIT,
	FlgFunPesquisa BIT,
	CONSTRAINT FK_Vet_Func FOREIGN KEY (IdVeterinario) REFERENCES Funcionario(IdFuncionario) ON DELETE CASCADE
);
GO

---- Pet

CREATE TABLE Especie(
	IdEspecie INT PRIMARY KEY IDENTITY(1,1),
	CodEspecie NVARCHAR(20) UNIQUE,
	DescEspecie NVARCHAR(50),
	Tipo NVARCHAR(10)
);
GO

CREATE TABLE Raca(
	IdRaca INT PRIMARY KEY IDENTITY(1,1),
	IdEspecie INT,
	CodRaca NVARCHAR(30) UNIQUE,
	DescRaca NVARCHAR(50) UNIQUE,
	TempCorpMin FLOAT,
	TempCorpMax FLOAT,
	ExpectativaDeVidaMin INT,
	ExpectativaDeVidaMax INT,
	ObsRaca NVARCHAR(MAX),
	CONSTRAINT FK_Raca_Espec FOREIGN KEY (IdEspecie) REFERENCES Especie(IdEspecie) ON DELETE CASCADE
);
GO

CREATE TABLE Pet(
	IdPet INT PRIMARY KEY IDENTITY(1,1),
	CodPet NVARCHAR(20),
	IdEspecie INT,
	IdRaca INT,
	DtNascimento Date,
	IdCliente INT,
	Sexo CHAR(1),
	Cor NVARCHAR(25),
	Exotico BIT,
	NumChip INT,
	Foto NVARCHAR(MAX),
	CONSTRAINT FK_Pet_Espec FOREIGN KEY (IdEspecie) REFERENCES Especie(IdEspecie) ON DELETE CASCADE,
	CONSTRAINT FK_Pet_Raca FOREIGN KEY (IdRaca) REFERENCES Raca(IdRaca) ON DELETE NO ACTION,
	CONSTRAINT FK_Pet_Cli FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente) ON DELETE CASCADE
);
GO

CREATE TABLE PesoIdade(
	IdRaca INT,
	IdadeMin INT,
	IdadeMax INT,
	PesoMin INT,
	PesoMax INT,
	CONSTRAINT FK_PesoIdade_Raca FOREIGN KEY (IdRaca) REFERENCES Raca(IdRaca) ON DELETE CASCADE
);
GO

---- Servico

CREATE TABLE Servico(
	IdServico INT PRIMARY KEY IDENTITY(1,1),
	CodServico NVARCHAR(20),
	DescServico NVARCHAR(50),
	ValorServico DECIMAL
);
GO

CREATE TABLE Atendimento(
	IdAtendimento INT PRIMARY KEY IDENTITY(1,1),
	IdPet INT,
	Titulo NVARCHAR(25),
	Descricao NVARCHAR(MAX),
	DataAtendimento DATETIME,
	Valor DECIMAL,
	IdVeterinario INT,
	IdCliente INT,
	CONSTRAINT FK_Atend_Pet FOREIGN KEY (IdPet) REFERENCES Pet(IdPet) ON DELETE NO ACTION,
	CONSTRAINT FK_Atend_Vet FOREIGN KEY (IdVeterinario) REFERENCES Funcionario(IdFuncionario) ON DELETE CASCADE,
	CONSTRAINT FK_Atend_Cli FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente) ON DELETE NO ACTION
);
GO

CREATE TABLE AtendimentoFoto(
	IdAtendimento INT,
	IdPet INT,
	Foto NVARCHAR(MAX),
	CONSTRAINT FK_AtendFoto_Atend FOREIGN KEY (IdAtendimento) REFERENCES Atendimento(IdAtendimento) ON DELETE NO ACTION,
	CONSTRAINT FK_AtendFoto_Pet FOREIGN KEY (IdPet) REFERENCES Pet(IdPet) ON DELETE NO ACTION
);
GO

---- Medicamento e Vacina

CREATE TABLE Medicamento(
	IdMedicamento INT PRIMARY KEY IDENTITY(1,1),
	CodMedicamento NVARCHAR(30),
	Nome NVARCHAR(70),
	Descricao NVARCHAR(MAX),
	Tipo NVARCHAR(30),
	Fabricante NVARCHAR(30),
);
GO

CREATE TABLE MedicamentoFornecedor(
	IdMedicamentoFornecedor INT PRIMARY KEY IDENTITY(1,1),
	IdMedicamento INT,
	Quantidade INT,
	Valor DECIMAL,
	Lote NVARCHAR(10),
	Validade DATE,
	IdFornecedor INT,
	CONSTRAINT FK_MedicFornec_Medic FOREIGN KEY (IdMedicamento) REFERENCES Medicamento(IdMedicamento) ON DELETE CASCADE,
	CONSTRAINT FK_MedicFornec_Fornec FOREIGN KEY (IdFornecedor) REFERENCES FarmaciaLaboratorio(IdFarmaciaLab) ON DELETE CASCADE
);
GO

CREATE TABLE Quimicos(
	IdQuimico INT PRIMARY KEY IDENTITY(1,1),
	IdMedicamento INT,
	UnidMed NVARCHAR(10),
	Compostos Nvarchar(60),
	Dosagem FLOAT,
	CONSTRAINT FK_Quim_Medic FOREIGN KEY (IdMedicamento) REFERENCES Medicamento(IdMedicamento) ON DELETE CASCADE
);
GO

CREATE TABLE Vacina(
	IdVacina INT PRIMARY KEY IDENTITY(1,1),
	CodVacina NVARCHAR(15),
	Nome NVARCHAR(30),
	Descricao NVARCHAR(MAX),
	Tipo NVARCHAR(30),
	Lote NVARCHAR(10),
	Validade DATE,
	DoseUnica BIT,
	QtdDose INT,
	Periodicidade INT,
	UnidTempo NVARCHAR(3)
);
GO

CREATE TABLE CarteiraVacina(
	IdCarteiraVac INT PRIMARY KEY IDENTITY(1,1),
	IdPet INT,
	IdVacina INT,
	Lote NVARCHAR(10),
	DataVacina DATE,
	DataRenovacao DATE,
	IdVeterinario INT,
	NumDose INT,
	CONSTRAINT FK_CartVac_Pet FOREIGN KEY (IdPet) REFERENCES Pet(IdPet) ON DELETE NO ACTION,
	CONSTRAINT FK_CartVac_Vac FOREIGN KEY (IdVacina) REFERENCES Vacina(IdVacina) ON DELETE CASCADE,
	CONSTRAINT FK_CartVac_Vet FOREIGN KEY (IdVeterinario) REFERENCES Funcionario(IdFuncionario) ON DELETE CASCADE
);
GO

CREATE TABLE Alergia(
	IdAlergia INT PRIMARY KEY IDENTITY(1,1),
	CodAlergia NVARCHAR(15) UNIQUE,
	NomeAlergia NVARCHAR(60),
	Tipo NVARCHAR(15),
);
GO

---- Tabelas de Junção

CREATE TABLE VeterinarioCompetencias(
	IdVeterinario INT,
	IdRaca INT,
	CONSTRAINT FK_VetComp_Vet FOREIGN KEY (IdVeterinario) REFERENCES Funcionario(IdFuncionario) ON DELETE CASCADE,
	CONSTRAINT FK_VetComp_Raca FOREIGN KEY (IdRaca) REFERENCES Raca(IdRaca) ON DELETE CASCADE
);
GO

CREATE TABLE ServicoResp(
	IdServico INT,
	IdVeterinario INT,
	CONSTRAINT FK_ServResp_Serv FOREIGN KEY (IdServico) REFERENCES Servico(IdServico) ON DELETE CASCADE,
	CONSTRAINT FK_ServResp_Vet FOREIGN KEY (IdVeterinario) REFERENCES Funcionario(IdFuncionario) ON DELETE CASCADE
);
GO

CREATE TABLE ServicoInsumos(
	IdServico INT,
	IdMedicamento INT,
	CONSTRAINT FK_ServIns_Serv FOREIGN KEY (IdServico) REFERENCES Servico(IdServico) ON DELETE CASCADE,
	CONSTRAINT FK_ServIns_Medic FOREIGN KEY (IdMedicamento) REFERENCES Medicamento(IdMedicamento) ON DELETE CASCADE
);
GO

CREATE TABLE ServicoVacinas(
	IdServico INT,
	IdVacina INT,
	CONSTRAINT FK_ServVac_Serv FOREIGN KEY (IdServico) REFERENCES Servico(IdServico) ON DELETE CASCADE,
	CONSTRAINT FK_ServVac_Vac FOREIGN KEY (IdVacina) REFERENCES Vacina(IdVacina) ON DELETE CASCADE
);
GO

CREATE TABLE AtendimentoServico(
	IdAtendimento INT,
	IdServico INT,
	CONSTRAINT FK_AtendServ_Atend FOREIGN KEY (IdAtendimento) REFERENCES Atendimento(IdAtendimento) ON DELETE NO ACTION,
	CONSTRAINT FK_AtendServ_Serv FOREIGN KEY (IdServico) REFERENCES Servico(IdServico) ON DELETE CASCADE
);
GO

CREATE TABLE AlergiaPet(
	IdPet INT,
	IdAlergia INT,
	CONSTRAINT FK_AlergPet_Pet FOREIGN KEY (IdPet) REFERENCES Pet(IdPet) ON DELETE NO ACTION,
	CONSTRAINT FK_AlergPet_Alerg FOREIGN KEY (IdAlergia) REFERENCES Alergia(IdAlergia) ON DELETE CASCADE
);
GO

CREATE TABLE ContratanteServico(
	IdContratante INT,
	IdServico INT,
	CONSTRAINT FK_ContrServ_Contr FOREIGN KEY (IdContratante) REFERENCES Contratante(IdContratante) ON DELETE CASCADE,
	CONSTRAINT FK_ContrServ_Serv FOREIGN KEY (IdServico) REFERENCES Servico(IdServico) ON DELETE CASCADE
);
GO