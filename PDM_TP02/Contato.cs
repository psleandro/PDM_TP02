﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PDM_TP02
{
    class Contato
    {
        public Contato(string nome, int idade, string profissao, string pais)
        {
            Nome = nome;
            Idade = idade;
            Profissao = profissao;
            Pais = pais;
        }
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Profissao { get; set; }

        public string Pais { get; set; }

        public override string ToString()
        {
            return Nome;
        }


    }
}
