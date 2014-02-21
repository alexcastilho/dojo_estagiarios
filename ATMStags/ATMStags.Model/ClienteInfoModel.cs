using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStags.Model
{
    public class ClienteInfoModel : ClienteModel
    {
        public double Saldo { get; set; }
        public DateTime DataValidadeCartao { get; set; }
        public int NumeroCartao { get; set; }
    }
}