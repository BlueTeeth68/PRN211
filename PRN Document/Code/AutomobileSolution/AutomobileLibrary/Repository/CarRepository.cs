using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void Add(Car car) => CarDBContext.Instance.AddNewCar(car);

        public void Delete(int carID) => CarDBContext.Instance.DeleteCar(carID);

        public Car GetCarById(int carId) => CarDBContext.Instance.GetCarByID(carId);

        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList();

        public void Update(Car car) => CarDBContext.Instance.UpdateCar(car);

    }
}
