using ATMStags.Model;

namespace ATMStags.Business
{
    public class MaquinaBusiness
    {
        public void Sacar(ClienteModel cliente, double valor, MaquinaModel maquina)
        {
            ContaBusiness contaBusiness = new ContaBusiness();
            CartaoBusiness cartaoBusiness = new CartaoBusiness();

            if (PossuiSaldo(maquina, valor) && 
                cartaoBusiness.VerificarValidade(cliente.Cartao) && 
                contaBusiness.VerificarSaldo(cliente.Conta, valor))
            {
                contaBusiness.Debitar(cliente.Conta, valor);
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