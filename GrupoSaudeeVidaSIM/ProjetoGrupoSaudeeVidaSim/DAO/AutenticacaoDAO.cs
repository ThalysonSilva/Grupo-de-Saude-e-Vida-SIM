using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;
using System.Collections.Generic;

namespace ProjetoGrupoSaudeeVidaSim.DAO
{
    using MySql.Data.MySqlClient;
    using System.Windows.Forms;

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

                        // Debugging: Verificar se os dados estão sendo lidos corretamente
                        MessageBox.Show($"ID: {id}, Usuario: {usuario}");

                        listaUsuarios.Add(new Autenticacao(id, usuario, "", ""));
                    }
                }
            }

            return listaUsuarios;
        }
    }
}