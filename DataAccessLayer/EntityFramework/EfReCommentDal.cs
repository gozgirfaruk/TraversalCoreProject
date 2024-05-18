using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReCommentDal : GenericRepository<ReComment>, IReCommentDal
    {
        private readonly TreversalContext _context;

        public EfReCommentDal(TreversalContext context)
        {
            _context = context;
        }

        public List<ReComment> GetListByFilter(Expression<Func<ReComment, bool>> filter)
        {
           var values = _context.ReComments.Where(filter);
            return values.ToList();
        }

        public List<ReComment> GetListWithCity()
        {
            var values =_context.ReComments.Include(x=>x.Destination).ToList();
            return values.ToList();
        }
    }
}
