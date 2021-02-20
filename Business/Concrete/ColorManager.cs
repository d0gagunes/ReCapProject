using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Colors entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Colors entity)
        {
            throw new NotImplementedException();
        }

        public Colors Get(Expression<Func<Colors, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
        {
            return _colorDal.GetAll();
        }

        public List<Colors> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Colors> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Colors entity)
        {
            throw new NotImplementedException();
        }
    }
}
