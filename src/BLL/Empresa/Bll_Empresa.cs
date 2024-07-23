using DAL.DALCONN;
using Microsoft.Win32.SafeHandles;
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


        public Cls_Empresa GetEmpresa(int id) 
        {
            Cls_Empresa empresa = new Cls_Empresa();
            try {

                if ( _SqlConnectionString == string.Empty ) 
                    return null; 

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
                    return null;

                //DB Interaction.
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

        public DataTable GetEmpresas() {
            DataTable empresa = new DataTable();

            if (_SqlConnectionString == string.Empty)
                return null;

            //DB Interaction.
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
                return null;

            //DB Interaction.
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


