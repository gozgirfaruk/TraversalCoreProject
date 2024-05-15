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
    public class DestinationMenager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationMenager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public List<Destination> GetAll()
        {
            return _destinationDal.GetAll();
        }

        public Destination GetbyId(int id)
        {
            return _destinationDal.GetById(id);
        }

        public void TDelete(Destination entity)
        {
            _destinationDal.Delete(entity);
        }

        public List<Destination> TGetListByFilter(Expression<Func<Destination, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Destination entity)
        {
            _destinationDal.Insert(entity);
        }

        public void TUpdate(Destination entity)
        {
           _destinationDal.Update(entity);
        }
    }
}
