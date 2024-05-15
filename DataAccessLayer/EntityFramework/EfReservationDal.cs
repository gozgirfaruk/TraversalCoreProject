using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> ListWithReservationAproval(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> ListWitReservationAccepted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> ListWitReservationRejected(int id)
        {
            throw new NotImplementedException();
        }
    }
}
