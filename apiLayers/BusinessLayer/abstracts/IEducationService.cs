using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstracts
{
    public interface IEducationService
    {
        void insert(education p);
        void update(education p);
        void delete(education p);
        List<education> getAll();
        education getById(int Id);
    }
}
