using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstracts
{
    public interface IProjectService
    {
        void insert(project p);
        void update(project p);
        void delete(project p);
        List<project> getAll();
        project getById(int Id);
    }
}
