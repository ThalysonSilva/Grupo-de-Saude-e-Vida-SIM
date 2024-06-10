using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;

namespace ProjetoGrupoSaudeeVidaSim.DAO
{
    public class ConsultaDAO
    {

        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";
        public MySqlConnection Conexao()
        {
            return new MySqlConnection(linkDB);
        }
        public void SalvarConsulta(Consulta consulta)
        {
            string inserir = "INSERT INTO consulta" +
                " (nome, nomeDaClinica, valorDaConsulta, dataDaConsulta, tipoDaConsulta, especialidade, nomeDoMedico, crm)" +
                "VALUES (@nome, @nomeDaClinica, @valorDaConsulta, @dataDaConsulta, @tipoDaConsulta, @especialidade, @nomeDoMedico, @crm)";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(inserir, conexao);
                cmd.Parameters.AddWithValue("@nome", consulta.Nome);
                cmd.Parameters.AddWithValue("@nomeDaClinica", consulta.NomeDaClinica);
                cmd.Parameters.AddWithValue("@valorDaConsulta", consulta.ValorDaConsulta);
                cmd.Parameters.AddWithValue("@dataDaConsulta", consulta.DataDaConsulta);
                cmd.Parameters.AddWithValue("@tipoDaConsulta", consulta.TipoDaConsulta);
                cmd.Parameters.AddWithValue("@especialidade", consulta.Especialidade);
                cmd.Parameters.AddWithValue("@nomeDoMedico", consulta.NomeDoMedico);
                cmd.Parameters.AddWithValue("@crm", consulta.Crm);

                cmd.ExecuteNonQuery();
            }
        }

        public Paciente BuscarPacientePorNomeOuCpf(string nome, string cpf)
        {
            string buscar = "SELECT * FROM paciente WHERE nome LIKE @nome OR cpf = @cpf";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(buscar, conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                cmd.Parameters.AddWithValue("@cpf", cpf);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Paciente
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Cpf = reader.GetString("cpf"),
                            Contato = reader.GetString("contato")
                        };

                    }
                }
            }
            return null;
        }
    }
}
