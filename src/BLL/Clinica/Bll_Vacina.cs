using DAL.DALCONN;
using Models.Clinica;
using System.Data.SqlClient;

namespace BLL.Clinica
{
    public class Bll_Vacina
    {
        public string _SqlConnectionString = string.Empty;

        public Cls_Vacina GetVacina(string cod)
        {

            Cls_Vacina vacina = new Cls_Vacina();
            try
            {

                if (_SqlConnectionString == string.Empty)
                    return null;

                //DB Interaction.
                using (DALCONN conn = new DALCONN(_SqlConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandText =
                            "SELECT [IdVacina]" +
                                ",[CodVacina] \r\n      " +
                                ",[Nome] \r\n      " +
                                ",[Descricao] \r\n      " +
                                ",[Tipo] \r\n      " +
                                //",[Fabricante] \r\n      " +
                                ",[Lote] \r\n      " +
                                ",[Validade] \r\n      " +
                                ",[DoseUnica] \r\n      " +
                                ",[QtdDose] \r\n      " +
                                ",[Periodicidade] \r\n      " +
                                ",[UnidTempo] \r\n      " +
                            "FROM [Vacina] \r\n      " +
                        "WHERE [CodVacina] = @cod";

                        sqlCommand.Parameters.AddWithValue("@cod", cod);

                        SqlDataReader reader = conn.ExecuteReader(sqlCommand.CommandText);

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                vacina.IdVacina = (int)reader["IdVacina"];
                                vacina.CodVacina = (string)reader["CodVacina"];
                                vacina.NomeVacina = (string)reader["Nome"];
                                vacina.Descricao = (string)reader["Descricao"];
                                vacina.Tipo = (string)reader["Tipo"];
                                vacina.Fabricante = "Teste";//(string)reader["Fabricante"];
                                vacina.Lote = (string)reader["Lote"];
                                vacina.Validade = (DateOnly)reader["Validade"];
                                vacina.DoseUnica = (bool)reader["DoseUnica"];
                                vacina.QtdDose = (int)reader["QtdDose"];
                                vacina.Periodicidade = (int)reader["Periodicidade"];
                                vacina.UnidTempo = (string)reader["UnidTempo"];


                            }

                        }

                    }

                }

                return vacina;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void PutVacina(Cls_Vacina vacina)
        {
            try
            {

                if (_SqlConnectionString == string.Empty)
                    throw new ArgumentNullException();

                //DB Interaction.
                using (DALCONN conn = new DALCONN(_SqlConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandText =
                            "INSERT INTO [Vacina] (\r\n      " +
                                  " [IdVacina]\r\n      " +
                                  ",[CodVacina]\r\n      " +
                                  ",[Nome]\r\n      " +
                                  ",[Descricao]\r\n      " +
                                  ",[Tipo]\r\n      " +
                                  ",[Lote]\r\n      " +
                                  ",[Validade]\r\n      " +
                                  ",[DoseUnica]\r\n      " +
                                  ",[QtdDose]\r\n      " +
                                  ",[Periodicidade]\r\n      " +
                                  ",[UnidTempo])\r\n      " +
                            "VALUES(\r\n      " +
                                  "@id\r\n      " +
                                  ", @cod\r\n      " +
                                  ", @nome\r\n      " +
                                  ", @descicao\r\n      " +
                                  ", @tipo\r\n      " +
                                  ", @lote\r\n      " +
                                  ", @validade\r\n      " +
                                  ", @doseUnica\r\n      " +
                                  ", @qtdDose\r\n      " +
                                  ", @periodicidade\r\n      " +
                                  ", @unidTempo)\r\n      ";

                        sqlCommand.Parameters.AddWithValue("@id", vacina.IdVacina);
                        sqlCommand.Parameters.AddWithValue("@cod", vacina.CodVacina);
                        sqlCommand.Parameters.AddWithValue("@nome", vacina.NomeVacina);
                        sqlCommand.Parameters.AddWithValue("@descicao", vacina.Descricao);
                        sqlCommand.Parameters.AddWithValue("@tipo", vacina.Tipo);
                        sqlCommand.Parameters.AddWithValue("@lote", vacina.Lote);
                        sqlCommand.Parameters.AddWithValue("@validade", vacina.Validade);
                        sqlCommand.Parameters.AddWithValue("@doseUnica", vacina.DoseUnica);
                        sqlCommand.Parameters.AddWithValue("@qtdDose", vacina.QtdDose); ;
                        sqlCommand.Parameters.AddWithValue("@periodicidade", vacina.Periodicidade);
                        sqlCommand.Parameters.AddWithValue("@unidTempo", vacina.UnidTempo);


                        conn.ExecuteNonQuery(sqlCommand.CommandText);

                    }

                }

            }
            catch (Exception ex)
            {

            }
        }

        public void DeleteVacina(Cls_Vacina vacina)
        {
            try
            {

                if (_SqlConnectionString == string.Empty)
                    throw new ArgumentNullException();

                //DB Interaction.
                using (DALCONN conn = new DALCONN(_SqlConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandText =
                            "DELETE FROM [Vacina] \r\n      " +
                            "WHERE [IdVacina] = @id AND [CodVacina] = @cod\r\n      ";

                        sqlCommand.Parameters.AddWithValue("@id", vacina.IdVacina);
                        sqlCommand.Parameters.AddWithValue("@cod", vacina.CodVacina);

                        conn.ExecuteNonQuery(sqlCommand.CommandText);
                    }

                }

            }
            catch (Exception ex)
            {

            }
        }

    }
}
