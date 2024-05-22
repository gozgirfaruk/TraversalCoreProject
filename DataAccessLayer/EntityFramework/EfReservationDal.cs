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
        public List<Reservation> ListAllAproval()
        {
            using var _context = new TreversalContext();
            var values = _context.Reservations.Include(x=>x.Destination).Where(y=>y.Status=="Onaylandı").ToList();
            return values;
        }

        public List<Reservation> ListWithReservationAproval(int id)
        {
            using var _context =  new TreversalContext();
            var values = _context.Reservations.Include(x=>x.Destination).Where(y=>y.AppUserID == id &&  y.Status=="Onay Bekliyor").ToList();
            return values;
        }

        public List<Reservation> ListWitReservationAccepted(int id)
        {
            using var _context = new TreversalContext();
            var values = _context.Reservations.Include(x => x.Destination).Where(y => y.AppUserID == id && y.Status == "Onaylandı").ToList();
            return values;
        }

        public List<Reservation> ListWitReservationRejected(int id)
        {
            using var _context = new TreversalContext();
            var values = _context.Reservations.Include(x => x.Destination).Where(y => y.AppUserID == id && y.Status == "Onaylanmadı").ToList();
            return values;
        }

    }
}
