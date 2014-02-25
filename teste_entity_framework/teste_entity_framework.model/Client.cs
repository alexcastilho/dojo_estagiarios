using System;

namespace teste_entity_framework.model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public string LastName { get; set; }
    }
}