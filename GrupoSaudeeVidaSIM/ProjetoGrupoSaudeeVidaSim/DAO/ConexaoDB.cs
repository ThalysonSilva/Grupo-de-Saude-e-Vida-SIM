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
    }
}
