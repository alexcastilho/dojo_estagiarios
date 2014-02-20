using ATMStags.Business.Interfaces;
using ATMStags.Data;
using ATMStags.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStags.Business
{
    public class ClienteBusiness : IBusiness<ClienteModel>
    {

        public void Inserir(ClienteModel obj)
        {
            ClienteData data = new ClienteData();
            data.Inserir(obj);
             
        }

        public void Atualizar(ClienteModel obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }

        public ClienteModel Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public List<ClienteModel> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
