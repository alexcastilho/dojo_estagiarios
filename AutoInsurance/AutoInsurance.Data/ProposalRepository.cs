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

            try
            {
                using (Database db = new Database())
                {
                    list = db.Proposal.Include("Car").Include("Insured").ToList();
                }

                return list;
            }
            catch (Exception)
            {
                throw;
            }
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