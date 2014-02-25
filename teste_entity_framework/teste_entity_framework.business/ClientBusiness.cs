using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste_entity_framework.data;
using teste_entity_framework.model;

namespace teste_entity_framework.business
{
    public class ClientBusiness
    {
        public void Insert(Client obj)
        {
            ClientData data = new ClientData();
            data.Insert(obj);
        }
    }
}
