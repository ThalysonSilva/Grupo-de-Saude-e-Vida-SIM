using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;

namespace ProjetoGrupoSaudeeVidaSim.DAO
{
    public class PacienteDAO
    {
        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";
        public MySqlConnection Conexao()
        {
            return new MySqlConnection(linkDB);
        }

        public void SalvarPaciente(Paciente paciente)
        {
            string inserir = "INSERT INTO paciente" +
                " (nome, cpf, contato, dataNasc, cep, endereco, numCasa, bairro, cidade, uf) " +
                "VALUES (@nome, @cpf, @contato, @dataNasc, @cep, @endereco, @numCasa, @bairro, @cidade, @uf)";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(inserir, conexao);
                cmd.Parameters.AddWithValue("@nome", paciente.Nome);
                cmd.Parameters.AddWithValue("@cpf", paciente.Cpf);
                cmd.Parameters.AddWithValue("@contato", paciente.Contato);
                cmd.Parameters.AddWithValue("@dataNasc", paciente.DataNascimento);
                cmd.Parameters.AddWithValue("@cep", paciente.Cep);
                cmd.Parameters.AddWithValue("@endereco", paciente.Endereco);
                cmd.Parameters.AddWithValue("@numCasa", paciente.NumCasa);
                cmd.Parameters.AddWithValue("@bairro", paciente.Bairro);
                cmd.Parameters.AddWithValue("@cidade", paciente.Cidade);
                cmd.Parameters.AddWithValue("@uf", paciente.UF);

                cmd.ExecuteNonQuery();
            }
        }

        public Paciente BuscarPaciente(string nome)
        {
            string buscar = "SELECT * FROM paciente WHERE nome LIKE @nome";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(buscar, conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Paciente
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Cpf = reader.GetString("cpf"),
                            Contato = reader.GetString("contato"),
                            DataNascimento = reader.GetDateTime("dataNasc"),
                            Cep = reader.GetString("cep"),
                            Endereco = reader.GetString("endereco"),
                            NumCasa = reader.GetInt32("numCasa"),
                            Bairro = reader.GetString("bairro"),
                            Cidade = reader.GetString("cidade"),
                            UF = reader.GetString("uf")
                        };
                    }
                }
            }
            return null;
        }

    }
}
