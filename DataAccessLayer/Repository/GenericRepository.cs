using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
      

        public void Delete(T t)
        {
            using var _context= new TreversalContext();
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var _context = new TreversalContext();
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var _context = new TreversalContext();
            var values = _context.Set<T>().Find(id);
            return values;
        }

        public void Insert(T t)
        {
            using var _context = new TreversalContext();
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            using var _context = new TreversalContext();
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
