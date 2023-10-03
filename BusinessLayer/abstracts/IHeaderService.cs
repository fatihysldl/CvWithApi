using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstracts
{
    public interface IHeaderService
    {
        void insert(header p);
        void update(header p);
        void delete(header p);
        List<header> getAll();
        header getById(int Id);
    }
}
