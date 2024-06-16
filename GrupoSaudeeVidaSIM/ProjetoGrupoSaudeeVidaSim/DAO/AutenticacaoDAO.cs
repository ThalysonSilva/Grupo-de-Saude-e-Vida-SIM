using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Collections.Generic;

namespace ProjetoGrupoSaudeeVidaSim.DAO
{
    using MySql.Data.MySqlClient;
    using ProjetoGrupoSaudeeVidaSim.DTO.ProjetoGrupoSaudeeVidaSim.DTO;

    public class AutenticacaoDAO
    {
        public readonly string linkDB = "datasource=localhost;username=root;password=;database=clinica";

        public MySqlConnection Conexao()
        {
            return new MySqlConnection(linkDB);
        }

        public void SalvarUsuario(Autenticacao autenticacao)
        {
            string inserir = "INSERT INTO usuario (usuario, senha, confsenha) VALUES (@usuario, @senha, @confsenha)";

            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(inserir, conexao);
                cmd.Parameters.AddWithValue("@usuario", autenticacao.Usuario);
                cmd.Parameters.AddWithValue("@senha", autenticacao.Senha);
                cmd.Parameters.AddWithValue("@confsenha", autenticacao.ConfSenha);

                cmd.ExecuteNonQuery();
            }
        }

        public bool AutenticarUsuario(string usuario, string senha)
        {
            string consulta = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND senha = @senha";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(consulta, conexao);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public List<Autenticacao> ConsultarUsuarios(string nomeUsuario)
        {
            List<Autenticacao> listaUsuarios = new List<Autenticacao>();

            string consulta = "SELECT id, usuario FROM usuario WHERE usuario LIKE @nomeUsuario";
            using (MySqlConnection conexao = Conexao())
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(consulta, conexao);
                cmd.Parameters.AddWithValue("@nomeUsuario", "%" + nomeUsuario + "%");

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string usuario = reader.GetString("usuario");

                        listaUsuarios.Add(new Autenticacao(id, usuario, "", ""));
                    }
                }
            }

            return listaUsuarios;
        }

        public void EditarUsuario(Autenticacao autenticacao)
        {
            string atualizar = "UPDATE usuario SET usuario = @usuario, senha = @senha, confsenha = @confsenha WHERE id = @id";

            try
            {
                using (MySqlConnection conexao = Conexao())
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand(atualizar, conexao))
                    {
                        cmd.Parameters.AddWithValue("@usuario", autenticacao.Usuario);
                        cmd.Parameters.AddWithValue("@senha", autenticacao.Senha);
                        cmd.Parameters.AddWithValue("@confsenha", autenticacao.ConfSenha);
                        cmd.Parameters.AddWithValue("@id", autenticacao.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log de erro ou outra forma de tratamento de exceção
                Console.WriteLine($"Erro ao atualizar usuário: {ex.Message}");
                // Lançar a exceção novamente se necessário
                throw;
            }
        }

        public void ExcluirUsuario(int id)
        {
            string deletar = "DELETE FROM usuario WHERE id = @id";

            try
            {
                using (MySqlConnection conexao = Conexao())
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand(deletar, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("Nenhum usuário encontrado com o ID fornecido.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log de erro ou outra forma de tratamento de exceção
                Console.WriteLine($"Erro ao excluir usuário: {ex.Message}");
                // Lançar a exceção novamente se necessário
                throw;
            }
        }
    }
}