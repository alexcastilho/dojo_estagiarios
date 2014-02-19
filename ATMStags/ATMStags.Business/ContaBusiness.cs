using ATMStags.Model;

namespace ATMStags.Business
{
    public class ContaBusiness
    {
        public void Debitar(ContaModel conta, double valor)
        {
            conta.Saldo -= valor;
        }

        public bool VerificarSaldo(ContaModel conta, double valor)
        {
            if (conta.Saldo < valor)
                throw new SaldoInsuficienteException();

            return true;
        }
    }
}