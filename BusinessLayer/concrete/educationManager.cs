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
    public class educationManager : IEducationService
    {
        IEducationDal _educationDal;

        public educationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public void delete(education p)
        {
            _educationDal.delete(p);
        }

        public List<education> getAll()
        {
            return _educationDal.getAll();
        }

        public education getById(int Id)
        {
            return _educationDal.getById(Id);
        }

        public void insert(education p)
        {
            _educationDal.insert(p);
        }

        public void update(education p)
        {
            _educationDal.update(p);
        }
    }
}
