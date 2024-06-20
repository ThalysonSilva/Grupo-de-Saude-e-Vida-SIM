using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Collections.Generic;

namespace ProjetoGrupoSaudeeVidaSim.DAO
{
    public class MedicoDAO
    {
        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";

        #region Método para abrir a conexão com o BD
        public MySqlConnection Conexao()
        {
            return new MySqlConnection(linkDB);
        }
        #endregion

        #region Método para salvar um novo médico
        public bool SalvarMedico(Medico medico)
        {
            if (medicoExiste(medico.Crm))
            {
                return false;
            }

            string inserir = "INSERT INTO medico" +
                             "(nome, crm, especialidade, diaDeAtendimento, horarioAtendimento)" +
                             "VALUES (@nome, @crm, @especialidade, @diaDeAtendimento, @horarioAtendimento)";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(inserir, conexao);
                cmd.Parameters.AddWithValue("@nome", medico.Nome);
                cmd.Parameters.AddWithValue("@crm", medico.Crm);
                cmd.Parameters.AddWithValue("@especialidade", medico.Especialidade);
                cmd.Parameters.AddWithValue("@diaDeAtendimento", medico.DataAtendimento);
                cmd.Parameters.AddWithValue("@horarioAtendimento", medico.HorarioAtendimento);

                cmd.ExecuteNonQuery();

                conexao.Close();
            }
            return true;
        }
        #endregion

        #region Método para buscar o médico pelo nome
        public Medico BuscarMedicoNome(string nome)
        {
            string buscar = "SELECT * FROM medico WHERE nome LIKE @nome ";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(buscar, conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");


                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Medico
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Crm = reader.GetInt32("crm"),
                            Especialidade = reader.GetString("especialidade"),
                            DataAtendimento = reader.GetString("diaDeAtendimento"),
                            HorarioAtendimento = reader.GetString("horarioAtendimento"),
                        };
                    }
                }
                conexao.Close();
            }
            return null;
        }
        #endregion

        #region Método para buscar o médico pelo CRM
        public Medico BuscarMedicoCrm(string crm)
        {
            string buscar = "SELECT * FROM medico WHERE crm = @crm ";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(buscar, conexao);

                cmd.Parameters.AddWithValue("@crm", crm);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Medico
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Crm = reader.GetInt32("crm"),
                            Especialidade = reader.GetString("especialidade"),
                            DataAtendimento = reader.GetString("diaDeAtendimento"),
                            HorarioAtendimento = reader.GetString("horarioAtendimento"),
                        };
                    }
                }
                conexao.Close();
            }
            return null;
        }
        #endregion

        #region Método para editar o médico
        public Medico EditarMedico(Medico medico)
        {
            string editar = "UPDATE medico " +
                            "SET nome=@nome, crm=@crm, especialidade=@especialidade, diaDeAtendimento=@diaDeAtendimento, horarioAtendimento=@horarioAtendimento " +
                            "WHERE crm=@crm";

            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand(editar, conexao);

                cmd.Parameters.AddWithValue("@nome", medico.Nome);
                cmd.Parameters.AddWithValue("@crm", medico.Crm);
                cmd.Parameters.AddWithValue("@especialidade", medico.Especialidade);
                cmd.Parameters.AddWithValue("@diaDeAtendimento", medico.DataAtendimento);
                cmd.Parameters.AddWithValue("@horarioAtendimento", medico.HorarioAtendimento);

                int linhaAtualizada = cmd.ExecuteNonQuery();

                if (linhaAtualizada == 0)
                {
                    throw new Exception("Nenhum registro foi atualizado.");
                }

                conexao.Close();

            }
            return null;
        }
        #endregion

        #region Método para Verifica se médico já existe no sistema
        public bool medicoExiste(int crm)
        {
            // Define a consulta SQL que conta o número de registros com o CPF fornecido
            string query = "SELECT COUNT(*) FROM medico WHERE crm = @crm";

            // Usando uma conexão com o banco de dados MySQL
            using (MySqlConnection conexao = Conexao())
            {
                // Abre a conexão com o banco de dados
                conexao.Open();

                // Cria um comando MySQL com a consulta definida anteriormente
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                // Adiciona o parâmetro CPF ao comando, substituindo o placeholder @cpf
                cmd.Parameters.AddWithValue("@crm", crm);

                // Executa a consulta e retorna o resultado como um inteiro
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Retorna true se o número de registros for maior que 0, ou seja, o paciente existe
                return count > 0;
            }
        }
        #endregion

        #region Método para excluir o médico
        public Medico ExcluirMedico(int crm)
        {
            string deletar = "DELETE FROM medico WHERE crm LIKE @crm";

            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(deletar, conexao);
                cmd.Parameters.AddWithValue("@crm", "%" + crm + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                conexao.Close();
            }
            return null;
        }
        #endregion

        #region Método para retonar uma list no forms de atendimento do médico
        public List<Consulta> BuscarConsultasPorNomeMedico(string nome)
        {
            List<Consulta> consultas = new List<Consulta>();
            string linkAtendimentoMedico = @"SELECT consulta.id, consulta.valorDaConsulta, consulta.dataDaConsulta, 
                             consulta.nomeDaClinica, consulta.tipoDaConsulta, paciente.nome AS nome, 
                             consulta.especialidade, consulta.nomeDoMedico, consulta.horarioDaConsulta, consulta.crm 
                             FROM consulta 
                             JOIN medico ON consulta.crm = medico.crm 
                             JOIN paciente ON consulta.nome = paciente.nome 
                             WHERE medico.nome LIKE @nome";

            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(linkAtendimentoMedico, conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

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
                            HorarioDaConsulta = reader.GetString("horarioDaConsulta"),
                            Crm = reader.GetInt32("crm")
                        };
                        consultas.Add(consulta);
                    }
                }
            }
            return consultas;
        }
        #endregion
    }
}
