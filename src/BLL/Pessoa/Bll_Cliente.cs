using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DALCONN;
using Models.Pessoa;
using System.Data.SqlClient;
using System.Data;


namespace BLL.Pessoa {
    public class Bll_Cliente {

        public string _SqlConnectionString = string.Empty;

        public Cls_Cliente GetCliente(int id) {

            Cls_Cliente cli = new Cls_Cliente();
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
                            "SELECT [IdPessoa] \r\n      " +
                                  ",[IdCliente] \r\n      " +
                                  ",[Cliente].[IdUsuario] \r\n      " +
                                  ",[Nome] \r\n      " +
                                  ",[CPF] \r\n      " +
                                  ",[DtNascimento] \r\n      " +
                                  ",[Endereco] \r\n      " +
                                  ",[Telefone] \r\n      " +
                                  ",[Email] \r\n      " +
                            "FROM [Cliente] \r\n      " +
                            "INNER JOIN [Pessoa] ON [Cliente].[IdUsuario] = [Pessoa].[IdUsuario] \r\n  " +
                            "WHERE [Cliente].[IdUsuario] = @id";
                        sqlCommand.Parameters.AddWithValue("@id", id);


                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows) {
                            while (reader.Read()) {

                                cli.SetIdUsuario(Convert.ToInt32(reader["IdUsuario"]));
                                cli.SetIdPessoa(Convert.ToInt32(reader["IdPessoa"]));
                                cli.SetNome(Convert.ToString(reader["Nome"]));
                                cli.SetCPF(Convert.ToString(reader["CPF"]));
                                cli.SetDtNascimento(Convert.ToDateTime(reader["DtNascimento"]));
                                cli.SetEndereco(Convert.ToString(reader["Endereco"]));
                                cli.SetTelefone(Convert.ToString(reader["Telefone"]));
                                cli.SetEmail(Convert.ToString(reader["Email"]));

                            }
                        }

                        connection.Close();
                    }

                }

                return cli;
            }
            catch (Exception ex) {
                return null;
            }
        }

        public List<Cls_Cliente> GetListClientes() {

            List<Cls_Cliente> lst_clientes = new List<Cls_Cliente>();
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
                            "SELECT [IdPessoa] \r\n      " +
                                  ",[IdCliente] \r\n      " +
                                  ",[Cliente].[IdUsuario] \r\n      " +
                                  ",[Nome] \r\n      " +
                                  ",[CPF] \r\n      " +
                                  ",[DtNascimento] \r\n      " +
                                  ",[Endereco] \r\n      " +
                                  ",[Telefone] \r\n      " +
                                  ",[Email] \r\n      " +
                            "FROM [Cliente] \r\n      " +
                            "INNER JOIN [Pessoa] ON [Cliente].[IdUsuario] = [Pessoa].[IdUsuario] \r\n  ";

                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.HasRows) {
                            while (reader.Read()) {
                                Cls_Cliente cliente = new Cls_Cliente();

                                cliente.SetIdUsuario(Convert.ToInt32(reader["IdUsuario"]));
                                cliente.SetIdPessoa(Convert.ToInt32(reader["IdPessoa"]));
                                cliente.SetNome(Convert.ToString(reader["Nome"]));
                                cliente.SetCPF(Convert.ToString(reader["CPF"]));
                                cliente.SetTelefone(Convert.ToString(reader["Telefone"]));
                                cliente.SetEmail(Convert.ToString(reader["Email"]));

                                lst_clientes.Add(cliente);
                            }
                        }

                        connection.Close();
                    }

                }

                return lst_clientes;
            }
            catch(Exception ex) {
                return null;
            }
        }


        public DataTable GetClientes() {
            DataTable cliente = new DataTable();

            if (_SqlConnectionString == string.Empty)
                return null;

            //DB Interaction.
            using (DALCONN conn = new DALCONN(_SqlConnectionString)) {
                using (SqlCommand sqlCommand = new SqlCommand()) {
                    sqlCommand.CommandText =
                        "SELECT [IdPessoa] \r\n      " +
                                  ",[IdCliente] \r\n      " +
                                  ",[Cliente].[IdUsuario] \r\n      " +
                                  ",[Nome] \r\n      " +
                                  ",[CPF] \r\n      " +
                                  ",[DtNascimento] \r\n      " +
                                  ",[Endereco] \r\n      " +
                                  ",[Telefone] \r\n      " +
                                  ",[Email] \r\n      " +
                            "FROM [Cliente] \r\n      " +
                            "INNER JOIN [Pessoa] ON [Cliente].[IdUsuario] = [Pessoa].[IdUsuario] \r\n  ";

                    conn.OpenConnection();

                    cliente = conn.ExecuteQuery(sqlCommand.CommandText);

                    conn.CloseConnection();
                }

            }

            return cliente;
        }


        public DataTable SearchClientes(string query) {
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