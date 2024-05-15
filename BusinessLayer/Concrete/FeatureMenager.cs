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
    public class FeatureMenager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureMenager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public List<Feature> GetAll()
        {
           return _featureDal.GetAll();
        }

        public Feature GetbyId(int id)
        {
            return _featureDal.GetById(id);
        }

        public void TDelete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public List<Feature> TGetListByFilter(Expression<Func<Feature, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Feature entity)
        {
            _featureDal.Insert(entity);
        }

        public void TUpdate(Feature entity)
        {
           _featureDal.Update(entity);
        }
    }
}
