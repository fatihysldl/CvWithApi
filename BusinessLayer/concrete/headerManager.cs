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
    public class headerManager : IHeaderService
    {
        IHeaderDal _headerDal;

        public headerManager(IHeaderDal headerDal)
        {
            _headerDal = headerDal;
        }

        public void delete(header p)
        {
            _headerDal.delete(p);
        }

        public List<header> getAll()
        {
            return _headerDal.getAll();
        }

        public header getById(int Id)
        {
            return _headerDal.getById(Id);
        }

        public void insert(header p)
        {
            _headerDal.insert(p);
        }

        public void update(header p)
        {
            _headerDal.update(p);
        }
    }
}
