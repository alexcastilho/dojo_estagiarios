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
    public class CarBusiness : IBusiness<Car>
    {
        public List<Car> FindAll()
        {
            try
            {
                CarRepository repository = new CarRepository();
                return repository.FindAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insert(Car car)
        {
            try
            {
                CarRepository carRepository = new CarRepository();
                carRepository.Insert(car);
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

        public void Delete(int id)
        {
            try
            {
                CarRepository carRepository = new CarRepository();
                carRepository.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Car Find(int id)
        {
            try
            {
                CarRepository carRepository = new CarRepository();
                return carRepository.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}