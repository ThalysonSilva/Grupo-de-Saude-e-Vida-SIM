using MySql.Data.MySqlClient;
using System;

namespace ProjetoGrupoSaudeeVidaSim.DAO
{
    public class Autenticacao
    {

        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";
        public MySqlConnection Conexao()
        {
            return new MySqlConnection(linkDB);
        }

    }
}
