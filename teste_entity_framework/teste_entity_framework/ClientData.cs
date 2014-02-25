using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_entity_framework.data
{
    public class ClientData
    {
        public void Insert(model.Client obj)
        {
            Database db = new Database();
            db.Cliente.Add(obj);
            db.SaveChanges();
        }
    }
}