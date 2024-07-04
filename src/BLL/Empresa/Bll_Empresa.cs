using DAL.DALCONN;
using Microsoft.Win32.SafeHandles;
using Models.Empresa;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace BLL.Empresa
{
    public class Bll_Empresa
    {
        public string _SqlConnectionString = string.Empty; 

        public Cls_Empresa GetEmpresa(int id) 
        {
            Cls_Empresa empresa = new Cls_Empresa();

            if ( _SqlConnectionString == string.Empty ) 
                return null; 

            //DB Interaction.
            using (DALCONN conn = new DALCONN(_SqlConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand()) 
                { 
                    sqlCommand.CommandText =
                        "SELECT [IdEmpresa]\r\n      " +
                          ",[CodEmpresa]\r\n      " +
                          ",[RazaoSocial]\r\n      " +
                          ",[Endereco]\r\n      " +
                          ",[CNPJ]\r\n      " +
                          ",[Telefone]\r\n      " +
                          ",[Unidade]\r\n      " +
                          ",[Logo]\r\n  " +
                        "FROM [Empresa]\r\n  " +
                        "WHERE [IdEmpresa] = ?";
                    sqlCommand.Parameters.AddWithValue("?", id);

                    conn.ExecuteQuery(sqlCommand.CommandText);

                }

            }

            return empresa;
        }
    }
}
