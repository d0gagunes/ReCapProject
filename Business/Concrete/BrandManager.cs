using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brands entity)
        {
            _brandDal.Add(Brands);


        }

       

        public void Delete(Brands entity)
        {
            _brandDal.Delete(Brands);
        }

        public void Delete(Brands entity)
        {
            throw new NotImplementedException();
        }

        public Brands Get(Expression<Func<Brands, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brands> GetAll(Expression<Func<Brands, bool>> filter = null)
        {
            return _brandDal.GetAll();
        }

        public List<Brands> GetCarsByBrandId(int id)
        {
            return _brandDal.GetById(b => b.Id == id);
        }

        public List<Brands> GetCarsByColorId(int id)
        {
            return _brandDal.GetByColorId(b => b.Id == id);
        }

        public void Update(Brands entity)
        {
            throw new NotImplementedException();
        }
    }
}
