using MySql.Data.MySqlClient;
using ProjetoGrupoSaudeeVidaSim.DTO;
using System;

namespace ProjetoGrupoSaudeeVidaSim.DAO
{
    public class MedicoDAO
    {
        private string linkDB = "datasource=localhost;username=root;password=;database=clinica";
        public MySqlConnection Conexao()
        {
            return new MySqlConnection(linkDB);
        }

        public void SalvarMedico(Medico medico)
        {
            string inserir = "INSERT INTO medico" +
                " (nome, crm, especialidade, diaDeAtendimento, horarioAtendimento)" +
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
            }
        }
    }
}
