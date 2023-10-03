using DataAccessLayer.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.concrete.repositories
{
    public class genericRepositoryDal<T> : IRepositoryDal<T> where T : class
    {
        private readonly context _context;

        public genericRepositoryDal(context context)
        {
            _context = context;
        }

        public void delete(T p)
        {
            _context.Remove(p);
            _context.SaveChanges();
        }

        public List<T> getAll()
        {
            return _context.Set<T>().ToList();  
        }

        public T getById(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public void insert(T p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void update(T p)
        {
            _context.Update(p);
            _context.SaveChanges();
        }
    }
}
