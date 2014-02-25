using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;
using AutoInsurance.Data.Interfaces;

namespace AutoInsurance.Data
{
    public class InsuredRepository : IRepository<Insured>
    {

        public void Insert(Insured obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    db.Insured.Add(obj);
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
            try
            {
                using (Database db = new Database())
                {
                    Insured insured = db.Insured.Find(id);
                    db.Insured.Remove(insured);

                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Insured obj)
        {
            throw new NotImplementedException();
        }

        public Insured Find(int id)
        {
            Insured insured = null;

            try
            {
                using (Database db = new Database())
                {
                    insured = db.Insured.Find(id);
                }

                return insured;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Insured> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}