using System;

namespace ProjetoGrupoSaudeeVidaSim.DTO
{
    public class Paciente : Pessoa
    {
        public string Cpf { get; set; }
        public string Contato { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public int NumCasa { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

        public Paciente(int id, string nome, string cpf, string contato, DateTime dataNascimento, string cep, string endereco, int numCasa, string bairro, string cidade, string uF)
            : base(id, nome)
        {
            Cpf = cpf;
            Contato = contato;
            DataNascimento = dataNascimento.Date;
            Cep = cep;
            Endereco = endereco;
            NumCasa = numCasa;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
        }
        public Paciente() { }
    }
}
