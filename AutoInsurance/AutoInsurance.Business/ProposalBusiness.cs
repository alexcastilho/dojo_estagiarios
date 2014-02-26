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
    public class ProposalBusiness: IBusiness<Proposal>
    {
        public void Insert(Proposal obj)
        {
            try
            {
                ProposalRepository proposalRepository = new ProposalRepository();
                obj.Value = new Random().Next(1, 5000);
                proposalRepository.Insert(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Proposal obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Proposal Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Proposal> FindAll()
        {
            try
            {
                ProposalRepository proposalRepository = new ProposalRepository();
                return proposalRepository.FindAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}