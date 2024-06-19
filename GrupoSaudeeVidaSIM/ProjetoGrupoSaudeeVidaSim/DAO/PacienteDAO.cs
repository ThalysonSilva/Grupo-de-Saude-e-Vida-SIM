using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Collections.Generic;

namespace ProjetoGrupoSaudeeVidaSim.DAO
{
    public class PacienteDAO
    {
        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";
        public MySqlConnection Conexao()
        {
            return new MySqlConnection(linkDB);
        }
        // Método para inserir/cadastrar paciente
        public bool SalvarPaciente(Paciente paciente)
        {
            // essa condição é para verificar se já existe paciente cadastrado com o cpf, se tiver, ele retorna falso para n deixar prosseguir em salvar duplicado
            if (PacienteExiste(paciente.Cpf))
            {
                return false;
            }

            string linkInserir = "INSERT INTO paciente" +
                " (nome, cpf, contato, dataNasc, cep, endereco, numCasa, bairro, cidade, uf) " +
                "VALUES (@nome, @cpf, @contato, @dataNasc, @cep, @endereco, @numCasa, @bairro, @cidade, @uf)";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(linkInserir, conexao);
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
            return true;
        }

        // Método para buscar informações do paciente atraves do nome ou cpf
        public Paciente BuscarPacientePorNomeOuCpf(string nome, string cpf)
        {
            //Método atuando no forms de cadastroPaciente
            string linkBuscarPaciente = "SELECT * FROM paciente WHERE nome LIKE @nome OR cpf = @cpf";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(linkBuscarPaciente, conexao);
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

        // Método para editar Paciente.
        public void AtualizarPaciente(Paciente paciente)
        {
            // Declaração da string SQL que será usada para atualizar os dados do paciente no banco de dados
            string linkAtualizarPaciente = "UPDATE paciente SET " +
                "nome = @nome, " +                 // Atualiza o campo 'nome'
                "contato = @contato, " +           // Atualiza o campo 'contato'
                "dataNasc = @dataNasc, " +         // Atualiza o campo 'dataNasc'
                "cep = @cep, " +                   // Atualiza o campo 'cep'
                "endereco = @endereco, " +         // Atualiza o campo 'endereco'
                "numCasa = @numCasa, " +           // Atualiza o campo 'numCasa'
                "bairro = @bairro, " +             // Atualiza o campo 'bairro'
                "cidade = @cidade, " +             // Atualiza o campo 'cidade'
                "uf = @uf " +                      // Atualiza o campo 'uf'
                "WHERE cpf = @cpf";                // Condição para atualizar o registro correspondente ao CPF fornecido

            // Criação de uma nova conexão com o banco de dados usando a string de conexão
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(linkAtualizarPaciente, conexao);

                // Adiciona os valores dos parâmetros ao comando para evitar SQL injection
                cmd.Parameters.AddWithValue("@nome", paciente.Nome);               // Adiciona o valor do nome
                cmd.Parameters.AddWithValue("@contato", paciente.Contato);         // Adiciona o valor do contato
                cmd.Parameters.AddWithValue("@dataNasc", paciente.DataNascimento); // Adiciona o valor da data de nascimento
                cmd.Parameters.AddWithValue("@cep", paciente.Cep);                 // Adiciona o valor do CEP
                cmd.Parameters.AddWithValue("@endereco", paciente.Endereco);       // Adiciona o valor do endereço
                cmd.Parameters.AddWithValue("@numCasa", paciente.NumCasa);         // Adiciona o valor do número da casa
                cmd.Parameters.AddWithValue("@bairro", paciente.Bairro);           // Adiciona o valor do bairro
                cmd.Parameters.AddWithValue("@cidade", paciente.Cidade);           // Adiciona o valor da cidade
                cmd.Parameters.AddWithValue("@uf", paciente.UF);                   // Adiciona o valor da UF (estado)
                cmd.Parameters.AddWithValue("@cpf", paciente.Cpf.Replace(".", "").Replace("-", ""));                 // Adiciona o valor do CPF (usado na condição WHERE)

                // Executa o comando SQL para atualizar os dados no banco de dados
                int linhaAtualizada = cmd.ExecuteNonQuery();

                if (linhaAtualizada == 0)
                {
                    throw new Exception("Nenhum registro foi atualizado. Verifique se o CPF está correto.");
                }

            }
        }

        // Método para verificar se o paciente existe realmente no BD atraves do cpf
        public bool PacienteExiste(string cpf)
        {
            // Define a consulta SQL que conta o número de registros com o CPF fornecido
            string linkVerificacao = "SELECT COUNT(*) FROM paciente WHERE cpf = @cpf";

            // Usando uma conexão com o banco de dados MySQL
            using (MySqlConnection conexao = Conexao())
            {
                // Abre a conexão com o banco de dados
                conexao.Open();

                // Cria um comando MySQL com a consulta definida anteriormente
                MySqlCommand cmd = new MySqlCommand(linkVerificacao, conexao);

                // Adiciona o parâmetro CPF ao comando, substituindo o placeholder @cpf
                cmd.Parameters.AddWithValue("@cpf", cpf.Replace(".", "").Replace("-", ""));

                // Executa a consulta e retorna o resultado como um inteiro
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Retorna true se o número de registros for maior que 0, ou seja, o paciente existe
                return count > 0;
            }
        }

        // Método para retornar informações do paciente
        public List<Paciente> BuscarPacienteEListar(string nome)
        {
            List<Paciente> pacientes = new List<Paciente>();
            string linkListar = "SELECT * FROM paciente WHERE nome LIKE @nome";

            try
            {
                using (MySqlConnection conexao = Conexao())
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand(linkListar, conexao);
                    //cmd.Parameters.AddWithValue("@cpf", cpf.Replace(".", "").Replace("-", ""));
                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Paciente paciente = new Paciente
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
                            pacientes.Add(paciente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler informações do paciente no Banco de dados: " + ex.Message);
                throw;
            }
            return pacientes;
        }

        //Método para excluir o paciente
        public Paciente ExcluirPaciente(string cpf)
        {
            string deletar = "DELETE FROM paciente WHERE cpf LIKE @cpf";

            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(deletar, conexao);
                cmd.Parameters.AddWithValue("@cpf", "%" + cpf + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                conexao.Close();
            }
            return null;
        }

        // Método para buscar consultas pelo nome ou CPF
        public List<Consulta> BuscarConsultasPorNomeOuCpf(string nome)
        {
            List<Consulta> consultas = new List<Consulta>();
            string query = @"SELECT consulta.id, consulta.valorDaConsulta, consulta.dataDaConsulta, 
                            consulta.nomeDaClinica, consulta.tipoDaConsulta, paciente.nome, 
                            consulta.especialidade, consulta.nomeDoMedico, consulta.crm 
                            FROM consulta 
                            JOIN paciente ON consulta.nome = paciente.nome 
                            WHERE paciente.nome LIKE @nome";

            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                //cmd.Parameters.AddWithValue("@cpf", cpf);

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
