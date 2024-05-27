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
    public class contactManager : IContactService
    {
        IContactDal _contactDal;

        public contactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void delete(contact p)
        {
            _contactDal.delete(p);
        }

        public List<contact> getAll()
        {
            return _contactDal.getAll();
        }

        public contact getById(int Id)
        {
            return _contactDal.getById(Id);
        }

        public void insert(contact p)
        {
            _contactDal.insert(p);
        }

        public void update(contact p)
        {
            _contactDal.update(p);
        }
    }
}
