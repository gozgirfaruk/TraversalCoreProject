using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetbyListAppUser(int id);
        List<Reservation> TListWithReservationAproval(int id);
        List<Reservation> TListWitReservationAccepted(int id);
        List<Reservation> TListWitReservationRejected(int id);
        List<Reservation> TListAllAproval();
    }
}
