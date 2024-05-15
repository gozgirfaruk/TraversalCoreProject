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
    public class ReCommentMenager : IReCommentService
    {
        private readonly IReCommentDal _recommentDal;

        public ReCommentMenager(IReCommentDal recommentDal)
        {
            _recommentDal = recommentDal;
        }

        public List<ReComment> GetAll()
        {
            return _recommentDal.GetAll();
        }

        public ReComment GetbyId(int id)
        {
            return _recommentDal.GetById(id);
        }

        public void TDelete(ReComment entity)
        {
            _recommentDal.Delete(entity);
        }

        public List<ReComment> GetCommentByFilter(int id)
        {
            return _recommentDal.GetListByFilter(x => x.DestinationID == id);
        }

        public List<ReComment> TGetListByFilter(Expression<Func<ReComment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TInsert(ReComment entity)
        {
            _recommentDal.Insert(entity);
        }

        public void TUpdate(ReComment entity)
        {
            _recommentDal.Update(entity);
        }
    }
}
