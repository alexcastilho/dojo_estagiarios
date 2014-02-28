using CorretorApplication.AutoInsurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoInsurance.AutoInsuranceSoapClient autoInsurance = new AutoInsurance.AutoInsuranceSoapClient();
            List<Proposal> ListProposal = autoInsurance.GetProposals().ToList<Proposal>();
            Console.BackgroundColor = ConsoleColor.Red;
            foreach (var item in ListProposal)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}",
                    item.Insured.FirstName,
                    item.Insured.Age,
                    item.Value.ToString("c"),
                    item.Car.Model,
                    item.Car.Manufacturer);
            }
        }
    }
}
