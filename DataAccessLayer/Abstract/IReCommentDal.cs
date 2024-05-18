using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReCommentDal : IGenericDal<ReComment>
    {
        List<ReComment> GetListByFilter(Expression<Func<ReComment, bool>> filter);

        List<ReComment> GetListWithCity();
    }   
}
