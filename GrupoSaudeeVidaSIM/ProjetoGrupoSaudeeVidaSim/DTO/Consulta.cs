using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrupoSaudeeVidaSim.DTO
{
    public class Consulta : Pessoa
    {
        public string NomeDaClinica { get; set; }
        public float ValorDaConsulta { get; set; }
        public DateTime DataDaConsulta { get; set; }
        public string TipoDaConsulta { get; set; }
        public string Especialidade { get; set; }
        public string NomeDoMedico { get; set; }
        public int Crm { get; set; }

        public Consulta(int id, string nome, string nomeDaClinica, float valorDaConsulta, DateTime dataDaConsulta, string tipoDaConsulta, string especialidade, string nomeDoMedico, int crm)
            : base(id, nome)
        {
            NomeDaClinica = nomeDaClinica;
            ValorDaConsulta = valorDaConsulta;
            DataDaConsulta = dataDaConsulta.Date;
            TipoDaConsulta = tipoDaConsulta;
            Especialidade = especialidade;
            NomeDoMedico = nomeDoMedico;
            Crm = crm;
        }
        public Consulta() { }
    }


}
