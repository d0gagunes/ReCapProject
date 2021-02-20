using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            this._carDal= carDal;
        }
        
        public void Add(Cars cars)
        {
            if (cars.DailyPrice > 0)
            {
                _carDal.Add(cars);
                Console.WriteLine("Arac sisteme eklendi.");
            }
            else
            {
                Console.WriteLine("Gunluk fiyat 0 olamaz. 0'dan buyuk bir sayi giriniz.");
            }
        }

        public void Delete(Cars cars)
        {
            _carDal.Delete(cars);
            Console.WriteLine("Araç sistemden silindi.");
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            return _carDal.GetAll();
        }

        public List<Cars> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(car => car.BrandId == id);
        }

        public List<Cars> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(car => car.ColorId == id);
        }

        public void Update(Cars cars)
        {
            if (cars.DailyPrice > 0)
            {
                _carDal.Update(cars);
                Console.WriteLine("Araç guncellenmistir.");
            }
            else
            {
                Console.WriteLine("Kiralama 0 olamaz. 0'dan buyuk bir sayi giriniz.");
            }
        }

        List<Cars> IServiceRepository<Cars>.Get(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}