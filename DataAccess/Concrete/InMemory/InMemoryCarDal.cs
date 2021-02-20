using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Cars> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Cars>
            {
                new Cars{CarId=1,BrandId=1,ColorId=1, CarName="Volvo", ModelYear=202,DailyPrice=100000,Description="Taksi" },
                new Cars{CarId=2,BrandId=2,ColorId=2,CarName="Jeep",ModelYear=2020,DailyPrice=20000,Description="Taksi"},
                new Cars{CarId=3,BrandId=3,ColorId=3,CarName="Fiat",ModelYear=2021,DailyPrice=30000,Description="Jeep"},
                new Cars{CarId=4,BrandId=4,ColorId=4,CarName="Mercedes", ModelYear=2017,DailyPrice=100000,Description="Jeep"}

            };
        }
        public void Add(Cars entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Cars entity)
        {
            Cars carToDelete = _cars.SingleOrDefault(a => a.CarId == entity.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Cars> Get(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            return _cars;
        }

        public Cars GetByColorId(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Cars GetById(int Id)
        {
            return _cars.FirstOrDefault(x => x.CarId == Id);
        }

        public Cars GetById(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Cars cars)
        {
            Cars newEntity = _cars.FirstOrDefault(x => x.CarId == cars.CarId);
            newEntity.BrandId = cars.BrandId;
            newEntity.ColorId = cars.ColorId;
            newEntity.DailyPrice = cars.DailyPrice;
            newEntity.Description = cars.Description;
            newEntity.ModelYear = cars.ModelYear;
        }

        Cars IEntityRepository<Cars>.Get(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
