using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideMenager : IGuideService
    {
        private readonly IGuideDal _guideDal;

        public GuideMenager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public List<Guide> GetAll()
        {
            return _guideDal.GetAll();
        }

        public Guide GetbyId(int id)
        {
            return _guideDal.GetById(id);
        }

        public void TDelete(Guide entity)
        {
            _guideDal.Delete(entity);
        }

        public void TInsert(Guide entity)
        {
            _guideDal.Insert(entity);
        }

        public void TUpdate(Guide entity)
        {
            _guideDal.Update(entity);
        }
    }
}
