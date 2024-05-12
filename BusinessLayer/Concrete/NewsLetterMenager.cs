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
    public class NewsLetterMenager : INewsLetterService
    {
        private readonly INewsLetterDal _newsDal;

        public NewsLetterMenager(INewsLetterDal newsDal)
        {
            _newsDal = newsDal;
        }

        public List<NewsLetter> GetAll()
        {
            return _newsDal.GetAll();
        }

        public NewsLetter GetbyId(int id)
        {
            return _newsDal.GetById(id);
        }

        public void TDelete(NewsLetter entity)
        {
            _newsDal.Delete(entity);
        }

        public void TInsert(NewsLetter entity)
        {
            _newsDal.Insert(entity);
        }

        public void TUpdate(NewsLetter entity)
        {
            _newsDal.Update(entity);
        }
    }
}
