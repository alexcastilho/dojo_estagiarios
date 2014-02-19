using ATMStags.Business.Exceptions;
using ATMStags.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStags.Business
{
    class CartaoBusiness
    {
        
        public bool VerificarValidade(CartaoModel cartao)
        {
           if(cartao.DataValidade < DateTime.Now)
            throw new CartaoInvalidoException();


            return true;
        }
    }
}
