using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstracts
{
    public interface IContactService
    {
        void insert(contact p);
        void update(contact p);
        void delete(contact p);
        List<contact> getAll();
        contact getById(int Id);
    }
}
