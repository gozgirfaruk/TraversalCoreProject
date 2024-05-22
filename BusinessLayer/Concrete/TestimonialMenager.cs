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
    public class TestimonialMenager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialMenager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public List<Testimonial> GetAll()
        {
            return _testimonialDal.GetAll();
        }

        public Testimonial GetbyId(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
        }

        public List<Testimonial> TGetListByFilter(Expression<Func<Testimonial, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void TStatusChangeFalse(int id)
        {
            _testimonialDal.StatusChangeFalse(id);
        }

        public void TStatusChangeTrue(int id)
        {
           _testimonialDal.StatusChangeTrue(id);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity); 
        }
    }
}
