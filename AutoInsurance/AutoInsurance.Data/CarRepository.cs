using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;
using AutoInsurance.Data.Interfaces;

namespace AutoInsurance.Data
{
    public class CarRepository : IRepository<Car>
    {
        public List<Car> FindAll()
        {
            List<Car> carros = new List<Car>();

            try
            {
                using (Database db = new Database())
                {
                    carros = (from c in db.Car
                              select c).ToList();
                }
                return carros;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insert(Car obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    db.Car.Add(obj);

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
                    var car = db.Car.Find(id);
                    db.Car.Remove(car);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Car obj)
        {
            throw new NotImplementedException();
        }

        public Car Find(int id)
        {
            Car car = null;

            try
            {
                using (Database db = new Database())
                {
                    car = db.Car.Find(id);
                }

                return car;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}