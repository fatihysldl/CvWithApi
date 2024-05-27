using BusinessLayer.abstracts;
using DataAccessLayer.abstracts;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.concrete
{
    public class aboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public aboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void delete(about p)
        {
            _aboutDal.delete(p);
        }

        public List<about> getAll()
        {
            return _aboutDal.getAll();
        }

        public about getById(int Id)
        {
           return _aboutDal.getById(Id);
        }

        public void insert(about p)
        {
            _aboutDal.insert(p);
        }

        public void update(about p)
        {
            _aboutDal.update(p);
        }
    }
}
