﻿using System;


namespace ProjetoGrupoSaudeeVidaSim.DTO
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Pessoa() { }
    }
}