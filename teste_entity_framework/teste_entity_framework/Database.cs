using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste_entity_framework.model;

namespace teste_entity_framework.data
{
    public class Database : DbContext
    {
        public DbSet<Client> Cliente { get; set; }
    }
}