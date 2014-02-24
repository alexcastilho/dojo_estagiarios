using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;

namespace AutoInsurance.Data
{
    public class CarRepository
    {
        public bool Save(Car obj)
        {
            return true;
        }

        public List<Car> FindAll()
        {
            // return new List<Car>(); 
            List<Car> carros = new List<Car>();

            carros.Add(new Car() 
            {
                Id = 1,
                Manufacturer = "Ferrari",
                Model = "F50",
                PhotoUrl = "http://upload.wikimedia.org/wikipedia/commons/2/2c/SC06_1995_Ferrari_F50.jpg"
            });

            carros.Add(new Car()
            {
                Id = 2,
                Manufacturer = "Honda",
                Model = "Civic",
                PhotoUrl = "http://carplace.virgula.uol.com.br/wp-content/uploads/2013/01/Honda-Civic-Aero-Pack-1.jpg"
            });

            carros.Add(new Car()
            {
                Id = 3,
                Manufacturer = "Volkswagen",
                Model = "Fusca",
                PhotoUrl = "http://listonas.com.br/wp-content/uploads/2013/04/fusca-listonas-2.jpg"     
            });


            return carros;
            
        }

        public Car FindById(int Id)
        {
            return new Car();
        }

        public bool Delete(Car obj)
        {
            return true;
        }
    }
}