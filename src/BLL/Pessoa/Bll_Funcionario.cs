using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DALCONN;
using Models.Pessoa;
using System.Data.SqlClient;


namespace BLL.Pessoa {
    public class Bll_Funcionario {

        public string _SqlConnectionString = string.Empty;

        public Cls_Funcionario GetFuncionario(int id) {

            Cls_Funcionario func = new Cls_Funcionario();
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
                            "SELECT [IdFuncionario] \r\n      " +
                                  ",[IdPessoa] \r\n      " +
                                  ",[Funcionario].[IdUsuario] \r\n      " +
                                  ",[Nome] \r\n      " +
                                  ",[CPF] \r\n      " +
                                  ",[DtNascimento] \r\n      " +
                                  ",[Endereco] \r\n      " +
                                  ",[Cargo] \r\n      " +
                                  ",[Departamento] \r\n      " +
                                  ",[FlgSalario] \r\n      " +
                                  ",[Salario] \r\n      " +
                                  ",[FlgComissao] \r\n      " +
                                  ",[Comissao] \r\n      " +
                                  ",[FlgTerceirizado] \r\n      " +
                                  ",[IdEmpresa] \r\n      " +
                                  ",[Inativo] \r\n      " +
                            "FROM [Funcionario] \r\n      " +
                            "INNER JOIN [Pessoa] ON [Funcionario].[IdUsuario] = [Pessoa].[IdUsuario] \r\n  " +
                            "WHERE [Funcionario].[IdUsuario] = @id";
                        sqlCommand.Parameters.AddWithValue("@id", id);


                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows) {
                            while (reader.Read()) {

                                func.SetIdUsuario(Convert.ToInt32(reader["IdUsuario"]));
                                func.SetIdPessoa(Convert.ToInt32(reader["IdPessoa"]));
                                func.SetNome(Convert.ToString(reader["Nome"]));
                                func.SetCPF(Convert.ToString(reader["CPF"]));
                                func.SetDtNascimento(Convert.ToDateTime(reader["DtNascimento"]));
                                func.SetEndereco(Convert.ToString(reader["Endereco"]));
                                func.SetCargo(Convert.ToString(reader["Cargo"]));
                                func.SetDepartamento(Convert.ToString(reader["Departamento"]));
                                func.SetFlgSalario(Convert.ToBoolean(reader["FlgSalario"]));
                                func.SetSalario(Convert.ToDecimal(reader["Salario"]));
                                func.SetFlgComissao(Convert.ToBoolean(reader["FlgComissao"]));
                                func.SetComissao(Convert.ToDecimal(reader["Comissao"]));
                                func.SetFlgTerceirizado(Convert.ToBoolean(reader["FlgTerceirizado"]));
                                func.SetIdEmpresa(Convert.ToInt32(reader["IdEmpresa"]));
                                func.SetFlgInativo(Convert.ToBoolean(reader["Inativo"]));

                            }
                        }

                        connection.Close();
                    }

                }

                return func;
            }
            catch (Exception ex) {
                return null;
            }
        }

        public List<Cls_Usuario> GetUsuarios() {

            List<Cls_Usuario> lst_usuarios = new List<Cls_Usuario>();
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
                            "SELECT [IdUsuario] \r\n      " +
                                  ",[Login] \r\n      " +
                                  ",[Senha] \r\n      " +
                                  ",[Ativo] \r\n      " +
                            "FROM [Usuario]";

                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows) {
                            while (reader.Read()) {
                                Cls_Usuario usuario = new Cls_Usuario();

                                usuario.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                                usuario.SetLogin(Convert.ToString(reader["Login"]));
                                usuario.SetSenha(Convert.ToString(reader["Senha"]));
                                usuario.Ativo = Convert.ToBoolean(reader["Ativo"]);

                                lst_usuarios.Add(usuario);
                            }
                        }

                        connection.Close();
                    }

                }

                return lst_usuarios;
            }
            catch(Exception ex) {
                return null;
            }
        }
            
    }
}