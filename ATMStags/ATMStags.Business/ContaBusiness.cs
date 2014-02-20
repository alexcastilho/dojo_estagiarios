using ATMStags.Business.Interfaces;
using ATMStags.Model;
using System.Collections.Generic;
using System;
using ATMStags.Data;

namespace ATMStags.Business
{
    public class ContaBusiness : IBusiness<ContaModel>
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

        public void Inserir(ContaModel obj)
        {
            try
            {
                ContaData data = new ContaData();
                data.Inserir(obj);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Atualizar(ContaModel obj)
        {
            throw new System.NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new System.NotImplementedException();
        }

        public ContaModel Buscar(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ContaModel> BuscarTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}