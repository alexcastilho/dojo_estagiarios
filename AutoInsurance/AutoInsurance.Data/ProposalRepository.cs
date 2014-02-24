using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;

namespace AutoInsurance.Data
{
    public class ProposalRepository
    {
        public bool Save(Proposal obj)
        {
            return true;
        }

        public List<Proposal> FindAll()
        {
            //return new List<Proposal>();

            List<Proposal> list = new List<Proposal>();

            list.Add(new Proposal
            {
                Id = 1,
                Value = 500,
                Car = new Car
                {
                    Id = 1,
                    Manufacturer = "Honda",
                    Model = "Civic",
                    PhotoUrl = String.Empty
                },
                Insured = new Insured
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Val John",
                    Age = 80
                }
            });

            return list;
        }

        public Proposal FindById(int Id)
        {
            return new Proposal();
        }

        public bool Delete(Proposal obj)
        {
            return true;
        }
    }
}