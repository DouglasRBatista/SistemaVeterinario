using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DALCONN;
using Models.Pessoa;
using System.Data.SqlClient;


namespace BLL.Pessoa {
    public class Bll_Usuario {

        public string _SqlConnectionString = string.Empty;

        public Cls_Usuario GetUsuario(int id) {

            Cls_Usuario usuario = new Cls_Usuario();
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
                            "FROM [Usuario] \r\n      " +
                            "WHERE [IdUsuario] = @id";
                        sqlCommand.Parameters.AddWithValue("@id", id);


                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows) {
                            while (reader.Read()) {

                                usuario.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                                usuario.SetLogin(Convert.ToString(reader["Login"]));
                                usuario.SetSenha(Convert.ToString(reader["Senha"]));
                                usuario.Ativo = Convert.ToBoolean(reader["Ativo"]);

                            }
                        }

                        connection.Close();
                    }

                }

                return usuario;
            }
            catch (Exception ex) {
                return null;
            }
        }

        public void UpdateUsuario(Cls_Usuario usuario) {

            try {

                //DB Interaction.
                using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                    using (SqlCommand sqlCommand = new SqlCommand()) {

                        SqlConnection connection = new SqlConnection(_SqlConnectionString);
                        sqlCommand.Connection = connection;
                        connection.Open();

                        sqlCommand.CommandText =
                            "UPDATE [Usuario] SET \r\n        " + 
                                  "  [Login] = @login \r\n      " +
                                  ", [Senha] = @senha \r\n      " +
                                  ", [Ativo] = @ativo \r\n      " +
                            "WHERE [IdUsuario] = @id";
                        sqlCommand.Parameters.AddWithValue("@login", usuario.Login);
                        sqlCommand.Parameters.AddWithValue("@senha", usuario.GetSenha());
                        sqlCommand.Parameters.AddWithValue("@ativo", usuario.Ativo);
                        sqlCommand.Parameters.AddWithValue("@id", usuario.IdUsuario);

                        sqlCommand.ExecuteNonQuery();

                        connection.Close();
                    }

                }

            }
            catch (Exception ex) {
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