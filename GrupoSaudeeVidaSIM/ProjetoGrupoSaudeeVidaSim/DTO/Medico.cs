using System;

namespace ProjetoGrupoSaudeeVidaSim.DTO
{
    public class Medico : Pessoa
    {
        public int Crm { get; set; }
        public string Especialidade { get; set; }
        public DateTime DataAtendimento { get; set; }
        public DateTime HorarioAtendimento { get; set; }

        public Medico(int id, string nome, int crm, string especialidade, DateTime dataAtendimento, DateTime horarioAtendimento)
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
