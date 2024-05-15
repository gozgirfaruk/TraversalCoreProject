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
    public class AddressMenager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressMenager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public List<Address> GetAll()
        {
            return _addressDal.GetAll();    
        }

        public Address GetbyId(int id)
        {
            return _addressDal.GetById(id);
        }

        public void TDelete(Address entity)
        {
            _addressDal.Delete(entity);
        }

        public List<Address> TGetListByFilter(Expression<Func<Address, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Address entity)
        {
            _addressDal.Insert(entity);
        }

        public void TUpdate(Address entity)
        {
            _addressDal.Update(entity);
        }
    }
}
