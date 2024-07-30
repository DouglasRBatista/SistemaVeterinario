using DAL.DALCONN;
using Microsoft.Win32.SafeHandles;
using Models.Clinica;
using Models.Empresa;
using Models.Pessoa;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;

namespace BLL.Empresa
{
    public class Bll_Empresa
    {
        public string _SqlConnectionString = string.Empty; 


        public void SetEmpresa(Cls_Empresa emp) {

            if (_SqlConnectionString == string.Empty)
                throw new ArgumentNullException();

            //DB Interaction.
            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {

                    SqlConnection connection = new SqlConnection(_SqlConnectionString);
                    sqlCommand.Connection = connection;
                    connection.Open();
                    sqlCommand.CommandText =
                            "INSERT INTO [Empresa] (\r\n      " +
                                  " [CodEmpresa]\r\n      " +
                                  ",[RazaoSocial]\r\n      " +
                                  ",[Endereco]\r\n      " +
                                  ",[CNPJ]\r\n      " +
                                  ",[Telefone]\r\n      " +
                                  ",[Unidade]\r\n      " +
                                  ",[Logo]\r\n      " +
                                  ",[Tipo])\r\n      " +
                            "VALUES(\r\n      " +
                                  "  @codempresa\r\n      " +
                                  ", @razaosocial\r\n      " +
                                  ", @endereco\r\n      " +
                                  ", @cnpj\r\n      " +
                                  ", @telefone\r\n      " +
                                  ", @unidade\r\n      " +
                                  ", @logo\r\n      " +
                                  ", @tipo)\r\n      ";

                    sqlCommand.Parameters.AddWithValue("@codempresa", emp.GetCodEmpresa());
                    sqlCommand.Parameters.AddWithValue("@razaosocial", emp.GetRazaoSocial());
                    sqlCommand.Parameters.AddWithValue("@endereco", emp.GetEndereco());
                    sqlCommand.Parameters.AddWithValue("@cnpj", emp.GetCNPJ());
                    sqlCommand.Parameters.AddWithValue("@telefone", emp.GetTelefone());
                    sqlCommand.Parameters.AddWithValue("@unidade", emp.GetUnidade());
                    if (emp.GetLogo() == null) {
                        sqlCommand.Parameters.AddWithValue("@logo", "");
                    }
                    else {
                        sqlCommand.Parameters.AddWithValue("@logo", emp.GetLogo());
                    }
                    sqlCommand.Parameters.AddWithValue("@tipo", emp.GetTipo());

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    connection.Close();
                }

            }
        }

        public void UpdateEmpresa(Cls_Empresa emp) {

            if (_SqlConnectionString == string.Empty)
                throw new ArgumentNullException();

            //DB Interaction.
            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {

                    SqlConnection connection = new SqlConnection(_SqlConnectionString);
                    sqlCommand.Connection = connection;
                    connection.Open();
                    sqlCommand.CommandText =
                            "UPDATE [Empresa] SET \r\n      " +
                                  " [CodEmpresa] = @codempresa \r\n      " +
                                  ",[RazaoSocial] = @razaosocial \r\n      " +
                                  ",[Endereco] = @endereco \r\n      " +
                                  ",[CNPJ] = @cnpj \r\n      " +
                                  ",[Telefone] = @telefone \r\n      " +
                                  ",[Unidade] = @unidade \r\n      " +
                                  ",[Logo] = @logo \r\n      " +
                                  ",[Tipo] = @tipo \r\n      " +
                            "WHERE [IdEmpresa] = @id";

                    sqlCommand.Parameters.AddWithValue("@id", emp.GetIdEmpresa());
                    sqlCommand.Parameters.AddWithValue("@codempresa", emp.GetCodEmpresa());
                    sqlCommand.Parameters.AddWithValue("@razaosocial", emp.GetRazaoSocial());
                    sqlCommand.Parameters.AddWithValue("@endereco", emp.GetEndereco());
                    sqlCommand.Parameters.AddWithValue("@cnpj", emp.GetCNPJ());
                    sqlCommand.Parameters.AddWithValue("@telefone", emp.GetTelefone());
                    sqlCommand.Parameters.AddWithValue("@unidade", emp.GetUnidade());
                    if (emp.GetLogo() == null) {
                        sqlCommand.Parameters.AddWithValue("@logo", "");
                    }
                    else {
                        sqlCommand.Parameters.AddWithValue("@logo", emp.GetLogo());
                    }
                    sqlCommand.Parameters.AddWithValue("@tipo", emp.GetTipo());

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    connection.Close();
                }

            }
        }

        public void SetFilial(Cls_Filial filial) {

            if (_SqlConnectionString == string.Empty)
                throw new ArgumentNullException();

            //DB Interaction.
            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {

                    SqlConnection connection = new SqlConnection(_SqlConnectionString);
                    sqlCommand.Connection = connection;
                    connection.Open();
                    sqlCommand.CommandText =
                            "INSERT INTO [Filial] (\r\n      " +
                                  " [IdFilial]\r\n      " +
                                  " [DayCare]\r\n      " +
                                  ",[CsvDayCare]\r\n      " +
                                  ",[UnidadeHospitalar]\r\n      " +
                                  ",[CsvUnidadeHospitalar]\r\n      " +
                                  ",[ProntoAtendimento]\r\n      " +
                                  ",[CsvProntoAtendimento]\r\n      " +
                                  ",[Farmacia]\r\n      " +
                                  ",[Custos])\r\n      " +
                            "VALUES(\r\n      " +
                                  "  @id\r\n      " +
                                  "  @daycare\r\n      " +
                                  ", @csvdaycare\r\n      " +
                                  ", @unidadehosp\r\n      " +
                                  ", @csvunidadehosp\r\n      " +
                                  ", @prontoatend\r\n      " +
                                  ", @csvprontoatend\r\n      " +
                                  ", @farmacia\r\n      " +
                                  ", @custos)\r\n      ";

                    sqlCommand.Parameters.AddWithValue("@id", filial.GetIdEmpresa());
                    sqlCommand.Parameters.AddWithValue("@daycare", filial.FlgDayCare);
                    sqlCommand.Parameters.AddWithValue("@csvdaycare", filial.CsvDayCare);
                    sqlCommand.Parameters.AddWithValue("@unidadehosp", filial.FlgUnidadeHospitalar);
                    sqlCommand.Parameters.AddWithValue("@csvunidadehosp", filial.CsvHospital);
                    sqlCommand.Parameters.AddWithValue("@prontoatend", filial.FlgProntoAtendimento);
                    sqlCommand.Parameters.AddWithValue("@csvprontoatend", filial.CsvProntoAtendimento);
                    sqlCommand.Parameters.AddWithValue("@farmacia", filial.FlgFarmacia);
                    sqlCommand.Parameters.AddWithValue("@custos", filial.GetCusto());

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    connection.Close();
                }

            }
        }

        public void UpdateFilial(Cls_Filial filial) {

            if (_SqlConnectionString == string.Empty)
                throw new ArgumentNullException();

            //DB Interaction.
            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {

                    SqlConnection connection = new SqlConnection(_SqlConnectionString);
                    sqlCommand.Connection = connection;
                    connection.Open();
                    sqlCommand.CommandText =
                            "UPDATE [Filial] SET \r\n      " +
                                  ",[DayCare] = @daycare \r\n      " +
                                  ",[CsvDayCare] = @csvdaycare \r\n      " +
                                  ",[UnidadeHospitalar] = @unidadehosp \r\n      " +
                                  ",[CsvUnidadeHospitalar] = @csvunidadehosp \r\n      " +
                                  ",[ProntoAtendimento] = @prontoatend \r\n      " +
                                  ",[CsvProntoAtendimento] = @csvprontoatend \r\n      " +
                                  ",[Farmacia] = @farmacia \r\n      " +
                                  ",[Custos] = @custos \r\n      " +
                            "WHERE [IdFilial] = @id";

                    sqlCommand.Parameters.AddWithValue("@id", filial.GetIdEmpresa());
                    sqlCommand.Parameters.AddWithValue("@daycare", filial.FlgDayCare);
                    sqlCommand.Parameters.AddWithValue("@csvdaycare", filial.CsvDayCare);
                    sqlCommand.Parameters.AddWithValue("@unidadehosp", filial.FlgUnidadeHospitalar);
                    sqlCommand.Parameters.AddWithValue("@csvunidadehosp", filial.CsvHospital);
                    sqlCommand.Parameters.AddWithValue("@prontoatend", filial.FlgProntoAtendimento);
                    sqlCommand.Parameters.AddWithValue("@csvprontoatend", filial.CsvProntoAtendimento);
                    sqlCommand.Parameters.AddWithValue("@farmacia", filial.FlgFarmacia);
                    sqlCommand.Parameters.AddWithValue("@custos", filial.GetCusto());

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    connection.Close();
                }

            }
        }

        public void SetContratante(Cls_Contratante contr) {

            if (_SqlConnectionString == string.Empty)
                throw new ArgumentNullException();

            //DB Interaction.
            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {

                    SqlConnection connection = new SqlConnection(_SqlConnectionString);
                    sqlCommand.Connection = connection;
                    connection.Open();
                    sqlCommand.CommandText =
                            "INSERT INTO [Contratante] (\r\n      " +
                                  " [IdContratante]\r\n      " +
                                  " [InicioContrato]\r\n      " +
                                  ",[FimContrato]\r\n      " +
                                  ",[CsvFinal]\r\n      " +
                                  ",[UnidadeIntegrada])\r\n      " +
                            "VALUES(\r\n      " +
                                  "  @id\r\n      " +
                                  "  @iniciocontr\r\n      " +
                                  ", @fimcontr\r\n      " +
                                  ", @csvfinal\r\n      " +
                                  ", @unidintegral)\r\n      ";

                    sqlCommand.Parameters.AddWithValue("@id", contr.GetIdEmpresa());
                    sqlCommand.Parameters.AddWithValue("@iniciocontr", contr.InicioContrato);
                    sqlCommand.Parameters.AddWithValue("@fimcontr", contr.FimContrato);
                    sqlCommand.Parameters.AddWithValue("@csvfinal", contr.GetCsvFinal());
                    sqlCommand.Parameters.AddWithValue("@unidintegral", contr.UnidadeIntegrada);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    connection.Close();
                }

            }
        }

        public void UpdateContratante(Cls_Contratante contr) {

            if (_SqlConnectionString == string.Empty)
                throw new ArgumentNullException();

            //DB Interaction.
            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {

                    SqlConnection connection = new SqlConnection(_SqlConnectionString);
                    sqlCommand.Connection = connection;
                    connection.Open();
                    sqlCommand.CommandText =
                            "UPDATE [Contratante] SET \r\n      " +
                                  ",[InicioContrato] = @iniciocontr \r\n      " +
                                  ",[FimContrato] = @fimcontr \r\n      " +
                                  ",[CsvFinal] = @csvfinal \r\n      " +
                                  ",[UnidadeIntegrada] = @unidintegral \r\n      " +
                            "WHERE [IdContratante] = @id";

                    sqlCommand.Parameters.AddWithValue("@id", contr.GetIdEmpresa());
                    sqlCommand.Parameters.AddWithValue("@iniciocontr", contr.InicioContrato);
                    sqlCommand.Parameters.AddWithValue("@fimcontr", contr.FimContrato);
                    sqlCommand.Parameters.AddWithValue("@csvfinal", contr.GetCsvFinal());
                    sqlCommand.Parameters.AddWithValue("@unidintegral", contr.UnidadeIntegrada);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    connection.Close();
                }

            }
        }

        public void SetFarmLab(Cls_FarmaciaLaboratorio farmLab) {

            if (_SqlConnectionString == string.Empty)
                throw new ArgumentNullException();

            //DB Interaction.
            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {

                    SqlConnection connection = new SqlConnection(_SqlConnectionString);
                    sqlCommand.Connection = connection;
                    connection.Open();
                    sqlCommand.CommandText =
                            "INSERT INTO [FarmaciaLaboratorio] (\r\n      " +
                                  " [IdFarmaciaLab]\r\n      " +
                                  " [FlgIntegrada]\r\n      " +
                                  " [FlgTerceirizada]\r\n      " +
                                  ",[IdFilial]\r\n      " +
                                  ",[FlgFornecedor]\r\n      " +
                                  ",[DescFarmLab]\r\n      " +
                                  ",[ObsFarmLab])\r\n      " +
                            "VALUES(\r\n      " +
                                  "  @id\r\n      " +
                                  "  @flgintegr\r\n      " +
                                  "  @flgterc\r\n      " +
                                  ", @idfilial\r\n      " +
                                  ", @flgforn\r\n      " +
                                  ", @desc\r\n      " +
                                  ", @obs)\r\n      ";

                    sqlCommand.Parameters.AddWithValue("@id", farmLab.GetIdEmpresa());
                    sqlCommand.Parameters.AddWithValue("@flgintegr", farmLab.FlgIntegrada);
                    sqlCommand.Parameters.AddWithValue("@flgterc", farmLab.FlgTerceirizada);
                    sqlCommand.Parameters.AddWithValue("@idfilial", farmLab.GetIdFilial());
                    sqlCommand.Parameters.AddWithValue("@flgforn", farmLab.FlgFornecedor);
                    sqlCommand.Parameters.AddWithValue("@desc", farmLab.DescFarmLab);
                    sqlCommand.Parameters.AddWithValue("@obs", farmLab.ObsFarmLab);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    connection.Close();
                }

            }
        }

        public void UpdateFarmLab(Cls_FarmaciaLaboratorio farmLab) {

            if (_SqlConnectionString == string.Empty)
                throw new ArgumentNullException();

            //DB Interaction.
            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {

                    SqlConnection connection = new SqlConnection(_SqlConnectionString);
                    sqlCommand.Connection = connection;
                    connection.Open();
                    sqlCommand.CommandText =
                            "UPDATE [FarmaciaLaboratorio] SET \r\n      " +
                                  ",[FlgIntegrada] = @flgintegr \r\n      " +
                                  ",[FlgTerceirizada] = @flgterc \r\n      " +
                                  ",[IdFilial] = @idfilial \r\n      " +
                                  ",[FlgFornecedor] = @flgforn \r\n      " +
                                  ",[DescFarmLab] = @desc \r\n      " +
                                  ",[ObsFarmLab] = @obs \r\n      " +
                            "WHERE [IdFarmaciaLab] = @id";

                    sqlCommand.Parameters.AddWithValue("@id", farmLab.GetIdEmpresa());
                    sqlCommand.Parameters.AddWithValue("@flgintegr", farmLab.FlgIntegrada);
                    sqlCommand.Parameters.AddWithValue("@flgterc", farmLab.FlgTerceirizada);
                    sqlCommand.Parameters.AddWithValue("@idfilial", farmLab.GetIdFilial());
                    sqlCommand.Parameters.AddWithValue("@flgforn", farmLab.FlgFornecedor);
                    sqlCommand.Parameters.AddWithValue("@desc", farmLab.DescFarmLab);
                    sqlCommand.Parameters.AddWithValue("@obs", farmLab.ObsFarmLab);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    connection.Close();
                }

            }
        }

        public Cls_Empresa GetEmpresa(int id) 
        {
            Cls_Empresa empresa = new Cls_Empresa();
            try {

                if ( _SqlConnectionString == string.Empty )
                    throw new ArgumentNullException();

                //DB Interaction.
                using (DALCONN conn = new DALCONN(_SqlConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand()) 
                    {

                        SqlConnection connection = new SqlConnection(_SqlConnectionString);
                        sqlCommand.Connection = connection;
                        connection.Open();

                        sqlCommand.CommandText =
                            "SELECT [IdEmpresa] \r\n      " +
                                  ",[CodEmpresa] \r\n      " +
                                  ",[RazaoSocial] \r\n      " +
                                  ",[Endereco] \r\n      " +
                                  ",[CNPJ] \r\n      " +
                                  ",[Telefone] \r\n      " +
                                  ",[Unidade] \r\n      " +
                                  ",[Logo] \r\n  " +
                            "FROM [Empresa] \r\n  " +
                            "WHERE [IdEmpresa] = @id";

                        sqlCommand.Parameters.AddWithValue("@id", id);

                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows) 
      {
                            while (reader.Read()) {
                                empresa.SetIdEmpresa(Convert.ToInt32(reader["IdEmpresa"]));
                                empresa.SetCodEmpresa(Convert.ToString(reader["CodEmpresa"]));
                                empresa.SetRazaoSocial(Convert.ToString(reader["RazaoSocial"]));
                                empresa.SetEndereco(Convert.ToString(reader["Endereco"]));
                                empresa.SetCNPJ(Convert.ToString(reader["CNPJ"]));
                                empresa.SetTelefone(Convert.ToString(reader["Telefone"]));
                                empresa.SetUnidade(Convert.ToString(reader["Unidade"]));
                                empresa.SetLogo(Convert.ToString(reader["Logo"]));
                            }
                        }

                        connection.Close();
                    }

                }

            }
            catch(Exception ex) {

            }
            return empresa;
        }

        public Cls_Empresa GetEmpresa(Cls_Empresa emp) {
            Cls_Empresa empresa = new Cls_Empresa();
            try {

                if (_SqlConnectionString == string.Empty)
                    throw new ArgumentNullException();

                using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                    using (SqlCommand sqlCommand = new SqlCommand()) {

                        SqlConnection connection = new SqlConnection(_SqlConnectionString);
                        sqlCommand.Connection = connection;
                        connection.Open();

                        sqlCommand.CommandText =
                            "SELECT [IdEmpresa] \r\n      " +
                                  ",[CodEmpresa] \r\n      " +
                                  ",[RazaoSocial] \r\n      " +
                                  ",[Endereco] \r\n      " +
                                  ",[CNPJ] \r\n      " +
                                  ",[Telefone] \r\n      " +
                                  ",[Unidade] \r\n      " +
                                  ",[Logo] \r\n  " +
                            "FROM [Empresa] \r\n  " +
                            "WHERE [CodEmpresa] = @codigo AND [RazaoSocial] = @razaosocial AND [CNPJ] = @cnpj";

                        sqlCommand.Parameters.AddWithValue("@codigo", emp.GetCodEmpresa());
                        sqlCommand.Parameters.AddWithValue("@razaosocial", emp.GetRazaoSocial());
                        sqlCommand.Parameters.AddWithValue("@cnpj", emp.GetCNPJ());

                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows) {
                            while (reader.Read()) {
                                empresa.SetIdEmpresa(Convert.ToInt32(reader["IdEmpresa"]));
                                empresa.SetCodEmpresa(Convert.ToString(reader["CodEmpresa"]));
                                empresa.SetRazaoSocial(Convert.ToString(reader["RazaoSocial"]));
                                empresa.SetEndereco(Convert.ToString(reader["Endereco"]));
                                empresa.SetCNPJ(Convert.ToString(reader["CNPJ"]));
                                empresa.SetTelefone(Convert.ToString(reader["Telefone"]));
                                empresa.SetUnidade(Convert.ToString(reader["Unidade"]));
                                empresa.SetLogo(Convert.ToString(reader["Logo"]));
                            }
                        }

                        connection.Close();
                    }

                }

            }
            catch (Exception ex) {

            }
            return empresa;
        }


        public List<Cls_Servico> GetServicoContratante(Cls_Contratante contr) {
            List<Cls_Servico> listServ = new List<Cls_Servico>();
            Cls_Servico serv = new Cls_Servico();

            try {

                if (_SqlConnectionString == string.Empty)
                    throw new ArgumentNullException();

                using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                    using (SqlCommand sqlCommand = new SqlCommand()) {

                        SqlConnection connection = new SqlConnection(_SqlConnectionString);
                        sqlCommand.Connection = connection;
                        connection.Open();

                        sqlCommand.CommandText =
                            "SELECT [ContratanteServico].[IdServico] \r\n      " +
                                  ",[CodServico] \r\n      " +
                                  ",[DescServico] \r\n      " +
                                  ",[ValorServico] \r\n      " +
                            "FROM [ContratanteServico] \r\n  " +
                            "INNER JOIN [Contratante] ON [ContratanteServico].[IdContratante] = [Contratante].[IdContratante]\r\n  " +
                            "INNER JOIN [Servico] ON [ContratanteServico].[IdServico] = [Servico].[IdServico]\r\n  " +
                            "WHERE [Contratante].[IdContratante] = @id";

                        sqlCommand.Parameters.AddWithValue("@id", contr.GetIdEmpresa());

                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows) {
                            while (reader.Read()) {
                                serv.IdServico = Convert.ToInt32(reader["IdEmpresa"]);
                                serv.CodServico = Convert.ToString(reader["CodServico"]);
                                serv.DescServico = Convert.ToString(reader["DescServico"]);
                                serv.ValorServico = Convert.ToDecimal(reader["ValorServico"]);

                                listServ.Add(serv);
                            }
                        }

                        connection.Close();
                    }

                }

            }
            catch (Exception ex) {

            }
            return listServ;
        }

        public void DelEmpresa(Cls_Empresa emp) {

            if (_SqlConnectionString == string.Empty)
                throw new ArgumentNullException();

            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {

                    SqlConnection connection = new SqlConnection(_SqlConnectionString);
                    sqlCommand.Connection = connection;
                    connection.Open();
                    sqlCommand.CommandText =
                            "DELETE FROM [Empresa] \r\n      " +
                            "WHERE [IdEmpresa] = @id";

                    sqlCommand.Parameters.AddWithValue("@id", emp.GetIdEmpresa());

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    connection.Close();
                }

            }
        }

        public DataTable GetEmpresas() {
            DataTable empresa = new DataTable();

            if (_SqlConnectionString == string.Empty)
                throw new ArgumentNullException();

            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {
                    sqlCommand.CommandText =
                        "SELECT [IdEmpresa]\r\n      " +
                              ",[CodEmpresa]\r\n      " +
                              ",[RazaoSocial]\r\n      " +
                              ",[Endereco]\r\n      " +
                              ",[CNPJ]\r\n      " +
                              ",[Telefone]\r\n      " +
                              ",[Unidade]\r\n      " +
                        "FROM [Empresa]\r\n ";

                    conn.OpenConnection();

                    empresa = conn.ExecuteQuery(sqlCommand.CommandText);

                    conn.CloseConnection();
                }

            }

            return empresa;
        }

        public DataTable SearchEmpresas(string query) {
            DataTable empresa = new DataTable();

            if (_SqlConnectionString == string.Empty)
                throw new ArgumentNullException();

            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {
                    sqlCommand.CommandText = query;

                    conn.OpenConnection();

                    empresa = conn.ExecuteQuery(sqlCommand.CommandText);

                    conn.CloseConnection();
                }

            }

            return empresa;
        }
    }
    
}


