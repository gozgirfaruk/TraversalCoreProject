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
    public class ContactMenager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactMenager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact GetbyId(int id)
        {
            return _contactDal.GetById(id);
        }

        public void TDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public List<Contact> TGetListByFilter(Expression<Func<Contact, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
