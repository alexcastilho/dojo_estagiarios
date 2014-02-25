using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Data;
using AutoInsurance.Model;
using AutoInsurance.Business.Interfaces;

namespace AutoInsurance.Business
{
    public class InsuredBusiness : IBusiness<Insured>
    {
        public void Insert(Insured obj)
        {
            try
            {
                InsuredRepository insuredRepository = new InsuredRepository();
                insuredRepository.Insert(obj);
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

        public void Delete(int id)
        {
            try
            {
                InsuredRepository insuredRepository = new InsuredRepository();
                insuredRepository.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Insured Find(int id)
        {
            try
            {
                InsuredRepository insuredRepository = new InsuredRepository();
                return insuredRepository.Find(id);
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