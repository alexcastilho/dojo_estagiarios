using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStags.Model
{
    public class CartaoModel
    {
        public int Id { get; set; }
        public DateTime DataValidade { get; set; }
        public ClienteModel Cliente { get; set; }
        public ContaModel Conta { get; set; }
    }
}