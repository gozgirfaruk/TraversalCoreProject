using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubAboutMenager : ISubAboutService
    {
        private readonly ISubAboutDal _subDal;

        public SubAboutMenager(ISubAboutDal subDal)
        {
            _subDal = subDal;
        }

        public List<SubAbout> GetAll()
        {
           return _subDal.GetAll();
        }

        public SubAbout GetbyId(int id)
        {
           return _subDal.GetById(id);
        }

        public void TDelete(SubAbout entity)
        {
            _subDal.Delete(entity);
        }

        public List<SubAbout> TGetListByFilter(Expression<Func<SubAbout, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TInsert(SubAbout entity)
        {
            _subDal.Insert(entity);
        }

        public void TUpdate(SubAbout entity)
        {
            _subDal.Update(entity);
        }
    }
}
