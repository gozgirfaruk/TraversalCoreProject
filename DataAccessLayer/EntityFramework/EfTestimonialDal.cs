using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public void StatusChangeFalse(int id)
        {
            using var _context = new TreversalContext();
            var values = _context.Testimonials.Find(id);
            values.Status = false;
            _context.Testimonials.Update(values);
            _context.SaveChanges();
        }

        public void StatusChangeTrue(int id)
        {
            using var _context = new TreversalContext();
            var values =_context.Testimonials.Find(id);
            values.Status=true;
            _context.Testimonials.Update(values);
            _context.SaveChanges();
        }
    }
}
