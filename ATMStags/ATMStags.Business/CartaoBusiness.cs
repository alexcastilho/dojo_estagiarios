using ATMStags.Business.Exceptions;
using ATMStags.Model;
using System;

namespace ATMStags.Business
{
    public class CartaoBusiness
    {
        public bool VerificarValidade(CartaoModel cartao)
        {
            if (cartao.DataValidade < DateTime.Now)
                throw new CartaoInvalidoException();

            return true;
        }
    }
}