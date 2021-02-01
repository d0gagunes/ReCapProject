using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{ BrandId= "Mercedes" , ColorId= "Black" , DailyPrice = 2979600 , Description= "G-Serisi" , Id=1},
            new Car{ BrandId= "Fiat" , ColorId= "White" , DailyPrice = 172000 , Description= "Egea Sedan" , Id=2},
            new Car{ BrandId= "Wolksvagen" , ColorId= "Dark Blue" , DailyPrice = 424300 , Description= "Passat" , Id=3},
            new Car{ BrandId= "Volvo" , ColorId= "Red" , DailyPrice = 677238 , Description= "V60 Cross Country B5 AWD" , Id=4},
            new Car{ BrandId= "Jeep" , ColorId= "Gray" , DailyPrice = 900000 , Description= "Compass" , Id=5},


            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {

            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;



        }
        public List<Car> GetById(int Id)
        {
         return  _cars.Where(c => c.Id == Id).ToList();

        }

    }
}
