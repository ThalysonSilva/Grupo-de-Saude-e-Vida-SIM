using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DTO;


namespace ProjetoGrupoSaudeeVidaSim.DAO
{
    public class ConexaoDB
    {
        private string data_source = "datasource=localhost;username=root;password=;database=clinica";

        public MySqlConnection Conexao()
        {
            return new MySqlConnection(data_source);
        }
    }
}
