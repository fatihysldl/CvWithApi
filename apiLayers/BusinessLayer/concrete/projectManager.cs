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
    public class projectManager : IProjectService
    {
        IProjectDal _projectDal;

        public projectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void delete(project p)
        {
            _projectDal.delete(p);
        }

        public List<project> getAll()
        {
            return _projectDal.getAll();    
        }

        public project getById(int Id)
        {
            return _projectDal.getById(Id);
        }

        public void insert(project p)
        {
            _projectDal.insert(p);
        }

        public void update(project p)
        {
            _projectDal.update(p);
        }
    }
}
