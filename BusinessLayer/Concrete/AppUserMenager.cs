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
    public class AppUserMenager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserMenager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public List<AppUser> GetAll()
        {
            return _appUserDal.GetAll();
        }

        public AppUser GetbyId(int id)
        {
           return _appUserDal.GetById(id);
        }

        public void TDelete(AppUser entity)
        {
            _appUserDal.Delete(entity);
        }

        public List<AppUser> TGetListByFilter(Expression<Func<AppUser, bool>> filter)
        {
            return _appUserDal.GetListByFilter(filter);
        }

        public void TInsert(AppUser entity)
        {
            _appUserDal.Insert(entity);
        }

        public void TUpdate(AppUser entity)
        {
           _appUserDal.Update(entity);
        }
    }
}
