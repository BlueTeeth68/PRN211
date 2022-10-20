using AutomobileLibrary.BussinessObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DatabaseAccess
{
    public class CarDBContext
    {
        //tao car list
        //xem lai collection in C#
        private static List<Car> CarList = new List<Car>(){
        new Car(1, "Blade", "Honda", 19000000, 2015),
        new Car(2, "Vision", "Honde", 35000000, 2020)
        };

        //singleton pattern
        private static CarDBContext instance = null;

        //?
        private static readonly object instanceLock = new object();

        public CarDBContext()
        {
        }

        //Tao property Instance de ket noi database
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }

        public Boolean IsEmpty() => !CarList.Any();

        public List<Car> GetCarList() => CarList;

        public Car GetCarByID(int ID)
        {
            //xem lai LINQ
            Car car = null;
            if (!IsEmpty())
            {
                car = CarList.SingleOrDefault(c => c.CarID == ID);
            } else
            {
                throw new Exception("Car list is empty.");
            }
            return car;
        }

        //Add a new Car
        public void AddNewCar(Car car)
        {
            if (car != null)
            {
                if (GetCarByID(car.CarID) == null)
                {
                    CarList.Add(car);
                }
                else
                {
                    throw new Exception("This car has been existed");
                }
            }
            else
            {
                throw new Exception("Car is null");
            }
        }

        //Update Car 
        public void UpdateCar(Car car)
        {
            Car check = GetCarByID(car.CarID);
            if (check != null)
            {
                int i = CarList.IndexOf(check);
                CarList[i] = car;
            }
            else
            {
                throw new Exception("Car does not exist.");
            }
        }

        //Delete a car
        public void DeleteCar(int carID)
        {
            Car car = GetCarByID(carID);
            if (car != null)
            {
                CarList.Remove(car);
            }
            else
            {
                throw new Exception("Car does not exist");
            }
        }
    }
}
