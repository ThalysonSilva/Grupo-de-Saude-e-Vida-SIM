namespace ProjetoGrupoSaudeeVidaSim.DTO
{
    public class Medico : Pessoa
    {
        public int Crm { get; set; }
        public string Especialidade { get; set; }
        public string DataAtendimento { get; set; }
        public string HorarioAtendimento { get; set; }

        public Medico(int id, string nome, int crm, string especialidade, string dataAtendimento, string horarioAtendimento)
            : base(id, nome)
        {
            Crm = crm;
            Especialidade = especialidade;
            DataAtendimento = dataAtendimento;
            HorarioAtendimento = horarioAtendimento;
        }
        public Medico() { }
    }
}
