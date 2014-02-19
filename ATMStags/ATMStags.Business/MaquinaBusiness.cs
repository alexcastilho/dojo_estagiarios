using ATMStags.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStags.Business
{
    public class MaquinaBusiness
    {
        public void Sacar(CartaoModel cartao, double valor, MaquinaModel maquina)
        {
            ContaBusiness contaBusiness = new ContaBusiness();
            CartaoBusiness cartaoBusiness = new CartaoBusiness();

            if (PossuiSaldo(maquina, valor) && 
                cartaoBusiness.VerificarValidade(cartao) && 
                contaBusiness.VerificarSaldo(cartao.Conta, valor))
            {
                contaBusiness.Debitar(cartao.Conta, valor);
                Debitar(maquina, valor);
            }
        }

        private bool PossuiSaldo(MaquinaModel maquina, double valor)
        {
            if (maquina.Saldo < valor)
                throw new MaquinaSaldoInsuficienteException();

            return true;
        }

        private void Debitar(MaquinaModel maquina, double valor)
        {
            maquina.Saldo -= valor;
        }
    }
}