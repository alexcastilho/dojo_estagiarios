using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoInsurance.Business;
using AutoInsurance.Model;

namespace AutoInsurance.UnitTest
{
    [TestClass]
    public class CarTest
    {
        private CarBusiness carBusiness;
        private Car car;

        [TestInitialize]
        public void Init()
        {
            carBusiness = new CarBusiness();
            car = new Car();
        }

        [TestMethod]
        public void TestInsert()
        {
            car.Manufacturer = "Ferrari";
            car.Model = "F50";
            car.PhotoUrl = string.Empty;

            carBusiness.Insert(car);

            Assert.IsTrue(car.Id > 0);
        }

        [TestMethod]
        public void TestDelete()
        {
            car.Manufacturer = "VW";
            car.Model = "Fusca";
            car.PhotoUrl = string.Empty;

            carBusiness.Insert(car);
            carBusiness.Delete(car.Id);

            Assert.IsNull(carBusiness.Find(car.Id));
        }

        [TestMethod]
        public void TestFindAll()
        {
            car.Manufacturer = "batman";
            car.Model = "batmovel";
            car.PhotoUrl = string.Empty;

            carBusiness.Insert(car);
            carBusiness.Insert(car);
            carBusiness.Insert(car);

            Assert.IsTrue(carBusiness.FindAll().Count > 2);
        }
    }
}