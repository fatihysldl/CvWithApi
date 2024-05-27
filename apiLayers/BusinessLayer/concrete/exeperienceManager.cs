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
    public class exeperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public exeperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void delete(experience p)
        {
            _experienceDal.delete(p);
        }

        public List<experience> getAll()
        {
            return _experienceDal.getAll(); 
        }

        public experience getById(int Id)
        {
            return _experienceDal.getById(Id);
        }

        public void insert(experience p)
        {
            _experienceDal.insert(p);
        }

        public void update(experience p)
        {
            _experienceDal.update(p);
        }
    }
}
