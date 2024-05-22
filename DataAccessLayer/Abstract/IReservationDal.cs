using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> ListWithReservationAproval(int id);
        List<Reservation> ListWitReservationAccepted(int id);
        List<Reservation> ListWitReservationRejected(int id);
        List<Reservation> ListAllAproval();

    }
}
