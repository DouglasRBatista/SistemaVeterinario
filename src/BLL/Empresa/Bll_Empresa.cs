using DAL.DALCONN;
using Microsoft.Win32.SafeHandles;
using Models.Empresa;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;

namespace BLL.Empresa
{
    public class Bll_Empresa
    {
        public string _SqlConnectionString = string.Empty; 

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
            catch(Exception e) {

            }
            return empresa;
        }
        public Cls_Empresa GetEmpresas() {
            Cls_Empresa empresa = new Cls_Empresa();

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
                              ",[Logo]\r\n  " +
                        "FROM [Empresa]\r\n ";

                    conn.ExecuteQuery(sqlCommand.CommandText);

                }

            }

            return empresa;
        }
    }
    
}


