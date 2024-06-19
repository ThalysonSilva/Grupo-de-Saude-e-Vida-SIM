using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoGrupoSaudeeVidaSim.DAO
{
    public class ConsultaDAO
    {

        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";
        public MySqlConnection Conexao()
        {
            return new MySqlConnection(linkDB);
        }
        //Método para salvar consulta
        public void SalvarConsulta(Consulta consulta)
        {
            string inserir = "INSERT INTO consulta" +
                " (nome, nomeDaClinica, valorDaConsulta, dataDaConsulta, tipoDaConsulta, especialidade, nomeDoMedico, horarioDaConsulta, crm)" +
                "VALUES (@nome, @nomeDaClinica, @valorDaConsulta, @dataDaConsulta, @tipoDaConsulta, @especialidade, @nomeDoMedico, @horarioDaConsulta, @crm)";
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
                cmd.Parameters.AddWithValue("@horarioDaConsulta", consulta.HorarioDaConsulta);
                cmd.Parameters.AddWithValue("@crm", consulta.Crm);

                cmd.ExecuteNonQuery();
            }
        }

        // Método para buscar paciente no banco de dados por nome
        public Paciente BuscarPacientePorNomeOuCpf(string nome, string cpf)
        {
            // comando para buscar paciente no banco de dados
            string buscar = "SELECT * FROM paciente WHERE nome LIKE @nome OR cpf = @cpf";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(buscar, conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                cmd.Parameters.AddWithValue("@cpf", cpf);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // verifica se o paciente foi encontrado
                    if (reader.Read())
                    {
                        // retorna o paciente encontrado
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
        
        // método para buscar consulta por nome e nome da clinica
        public Consulta EditarConsulta(Consulta consulta)
        {
            string editar = "UPDATE consulta SET nome = @nome, nomeDaClinica = @nomeDaClinica, valorDaConsulta = @valorDaConsulta, dataDaConsulta = @dataDaConsulta, tipoDaConsulta = @tipoDaConsulta, especialidade = @especialidade, nomeDoMedico = @nomeDoMedico, crm = @crm WHERE nome = @nome AND nomeDaClinica = @nomeDaClinica";

            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();

                // Verifica se a consulta existe antes de tentar atualizar
                if (!consultaExiste(consulta.Nome, consulta.NomeDaClinica))
                {
                    throw new Exception("A consulta com o nome e a clínica fornecidos não existe.");
                }
                // comando para atualizar a consulta no banco de dados
                MySqlCommand cmd = new MySqlCommand(editar, conexao);
                cmd.Parameters.AddWithValue("@nome", consulta.Nome);
                cmd.Parameters.AddWithValue("@nomeDaClinica", consulta.NomeDaClinica);
                cmd.Parameters.AddWithValue("@valorDaConsulta", consulta.ValorDaConsulta);
                cmd.Parameters.AddWithValue("@dataDaConsulta", consulta.DataDaConsulta);
                cmd.Parameters.AddWithValue("@tipoDaConsulta", consulta.TipoDaConsulta);
                cmd.Parameters.AddWithValue("@especialidade", consulta.Especialidade);
                cmd.Parameters.AddWithValue("@nomeDoMedico", consulta.NomeDoMedico);
                cmd.Parameters.AddWithValue("@crm", consulta.Crm);

                int linhaAtualizada = cmd.ExecuteNonQuery();

                if (linhaAtualizada == 0)
                {
                    throw new Exception("Nenhuma consulta foi atualizada.");
                }

                conexao.Close();
            }
            return null;
        }

        // método para verificaar se a consulta existe, consulta feita pelo nome e nome da clinica
        public bool consultaExiste(string nome, string nomeDaClinica)
        {
            string buscar = "SELECT COUNT(*) FROM consulta WHERE nome = @nome AND nomeDaClinica = @nomeDaClinica";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(buscar, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@nomeDaClinica", nomeDaClinica);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public List<Consulta> BuscarConsultasPorNomeClinica(string nomeDaClinica)
        {
            List<Consulta> consultas = new List<Consulta>();
            string query = @"SELECT consulta.id, consulta.valorDaConsulta, consulta.dataDaConsulta, 
                            consulta.nomeDaClinica, consulta.tipoDaConsulta, paciente.nome, 
                            consulta.especialidade, consulta.nomeDoMedico, consulta.crm 
                            FROM consulta 
                            JOIN paciente ON consulta.nome = paciente.nome 
                           WHERE consulta.nomeDaClinica LIKE @nomeDaClinica";

            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@nomeDaClinica", "%" + nomeDaClinica + "%");

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Consulta consulta = new Consulta
                        {
                            Id = reader.GetInt32("id"),
                            ValorDaConsulta = reader.GetFloat("valorDaConsulta"),
                            DataDaConsulta = reader.GetDateTime("dataDaConsulta"),
                            NomeDaClinica = reader.GetString("nomeDaClinica"),
                            TipoDaConsulta = reader.GetString("tipoDaConsulta"),
                            Nome = reader.GetString("nome"),
                            Especialidade = reader.GetString("especialidade"),
                            NomeDoMedico = reader.GetString("nomeDoMedico"),
                            Crm = reader.GetInt32("crm")
                        };
                        consultas.Add(consulta);
                    }
                }
            }
            return consultas;
        }

    }
}
