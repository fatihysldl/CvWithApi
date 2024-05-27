using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstracts
{
    public interface IExperienceService
    {
        void insert(experience p);
        void update(experience p);
        void delete(experience p);
        List<experience> getAll();
        experience getById(int Id);
    }
}
