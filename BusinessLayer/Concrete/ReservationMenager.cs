using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationMenager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationMenager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetAll()
        {
            return _reservationDal.GetAll();
        }

        public Reservation GetbyId(int id)
        {
           return _reservationDal.GetById(id);
        }

        public void TDelete(Reservation entity)
        {
            _reservationDal.Delete(entity);
        }

        public void TInsert(Reservation entity)
        {
            _reservationDal.Insert(entity);
        }

        public void TUpdate(Reservation entity)
        {
            _reservationDal.Update(entity);
        }
    }
}
