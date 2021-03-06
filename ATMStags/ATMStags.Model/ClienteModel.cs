﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStags.Model
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public String CPF { get; set; }
        public String RG { get; set; }
        public int Idade { get; set; }
        public int IdCartao { get; set; }
        public int IdConta { get; set; }

        public CartaoModel Cartao { get; set; }
        public ContaModel Conta { get; set; }
    }
}