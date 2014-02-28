using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste_webservice_consumidor.WebserviceTeste;


namespace teste_webservice_consumidor
{
    /// <summary>
    /// TEste
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WebserviceTeste.WebServiceSoapClient proxy = new WebserviceTeste.WebServiceSoapClient();
            Console.WriteLine(proxy.HelloWorld());

            Cliente[] clientes = proxy.GetCliente();

            //foreach (var item in clientes)
            //{
            //    Console.WriteLine("{0} {1} {2}",
            //        item.Id,
            //            item.Nome,
            //                item.Ano);
            //}

            proxy.UpdateCliente(3);
        }
    }
}