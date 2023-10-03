using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.abstracts
{
    public interface IRepositoryDal<T> where T : class
    {
        void insert(T p);
        void update(T p);
        void delete(T p);
        List <T> getAll();
        T getById (int Id);

    }
}
