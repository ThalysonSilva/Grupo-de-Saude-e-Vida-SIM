using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;

namespace ProjetoGrupoSaudeeVidaSim.DAO
{
    public class AutenticacaoDAO
    {

        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";
        public MySqlConnection Conexao()
        {
            return new MySqlConnection(linkDB);
        }
        public void SalvarUsuario (Autenticacao autenticacao) 
        {
            String inserir = "INSERT INTO usuario" +
                " (usuario, senha, confsenha)" +
                "VALUES (@usuario, @senha, @confsenha)";
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
    }
}
