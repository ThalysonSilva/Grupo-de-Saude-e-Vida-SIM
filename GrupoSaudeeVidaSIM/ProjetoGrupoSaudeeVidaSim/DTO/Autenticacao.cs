using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrupoSaudeeVidaSim.DTO
{
    public class Autenticacao
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string ConfSenha { get; set; }

        public Autenticacao(int id, string usuario, string senha, string confSenha)
        {
            Id = id;
            Usuario = usuario;
            Senha = senha;
            ConfSenha = confSenha;
        }
    }
}