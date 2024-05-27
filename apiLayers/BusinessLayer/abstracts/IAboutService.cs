using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstracts
{
    public interface IAboutService
    {
        void insert(about p);
        void update(about p);
        void delete(about p);
        List<about> getAll();
        about getById(int Id);
    }
}
