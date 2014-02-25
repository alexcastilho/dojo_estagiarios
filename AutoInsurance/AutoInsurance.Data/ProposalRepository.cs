using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;
using AutoInsurance.Data.Interfaces;

namespace AutoInsurance.Data
{
    public class ProposalRepository : IRepository<Proposal> 
    {
        public List<Proposal> FindAll()
        {
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

        public void Insert(Proposal obj)
        {
            try
            {
                using (Database db = new Database()) 
                {
                    db.Entry(obj.Insured).State = System.Data.EntityState.Unchanged;
                    db.Entry(obj.Car).State = System.Data.EntityState.Unchanged;
                    db.Proposal.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Proposal obj)
        {
            throw new NotImplementedException();
        }

        public Proposal Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}