using ATMStags.Business.Exceptions;
using ATMStags.Business.Interfaces;
using ATMStags.Data;
using ATMStags.Model;
using System;
using System.Collections.Generic;

namespace ATMStags.Business
{
    public class CartaoBusiness : IBusiness<CartaoModel>
    {
        public bool VerificarValidade(CartaoModel cartao)
        {
            if (cartao.DataValidade < DateTime.Now)
                throw new CartaoInvalidoException();

            return true;
        }

        public void Inserir(CartaoModel cartao)
        {
            try
            {
                CartaoData data = new CartaoData();
                data.Inserir(cartao);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CartaoModel Buscar(int Id)
        {
            try
            {
                CartaoData data = new CartaoData();
                return data.Buscar(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CartaoModel> BuscarTodos()
        {
            try
            {
                CartaoData data = new CartaoData();
                return data.BuscarTodos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualizar(CartaoModel obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(int Id)
        {
            throw new NotImplementedException();
        }
    }
}