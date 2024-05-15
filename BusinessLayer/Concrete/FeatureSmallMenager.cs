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
    public class FeatureSmallMenager : IFeatureSmallService
    {
        private readonly IFeatureSmallDal _featureSDal;

        public FeatureSmallMenager(IFeatureSmallDal featureSDal)
        {
            _featureSDal = featureSDal;
        }

        public List<FeatureSmall> GetAll()
        {
            return _featureSDal.GetAll();
        }

        public FeatureSmall GetbyId(int id)
        {
            return _featureSDal.GetById(id);
        }

        public void TDelete(FeatureSmall entity)
        {
            _featureSDal.Delete(entity);
        }

        public List<FeatureSmall> TGetListByFilter(Expression<Func<FeatureSmall, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TInsert(FeatureSmall entity)
        {
            _featureSDal.Insert(entity);
        }

        public void TUpdate(FeatureSmall entity)
        {
            _featureSDal.Update(entity);
        }
    }
}
