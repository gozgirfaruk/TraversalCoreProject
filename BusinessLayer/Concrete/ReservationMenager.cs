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

        public List<Reservation> GetbyListAppUser(int id)
        {
            return _reservationDal.GetListByFilter(x=>x.AppUserID == id && x.Status=="Onay Bekliyor");
        }

        public void TDelete(Reservation entity)
        {
            _reservationDal.Delete(entity);
        }

        public List<Reservation> TGetListByFilter(Expression<Func<Reservation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Reservation entity)
        {
            _reservationDal.Insert(entity);
        }

        public List<Reservation> TListWithReservationAproval(int id)
        {
            return _reservationDal.ListWithReservationAproval(id);
        }

        public List<Reservation> TListWitReservationAccepted(int id)
        {
            return _reservationDal.ListWitReservationAccepted(id); 
        }

        public List<Reservation> TListWitReservationRejected(int id)
        {
            return _reservationDal.ListWitReservationRejected(id);
        }

        public void TUpdate(Reservation entity)
        {
            _reservationDal.Update(entity);
        }
    }
}
