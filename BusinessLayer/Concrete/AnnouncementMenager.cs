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
    public class AnnouncementMenager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementMenager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public List<Announcement> GetAll()
        {
            return _announcementDal.GetAll();
        }

        public Announcement GetbyId(int id)
        {
            return _announcementDal.GetById(id);
        }

        public void TDelete(Announcement entity)
        {
            _announcementDal.Delete(entity);
        }

        public List<Announcement> TGetListByFilter(Expression<Func<Announcement, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Announcement entity)
        {
            _announcementDal.Insert(entity);
        }

        public void TUpdate(Announcement entity)
        {
            _announcementDal.Update(entity);
        }
    }
}
