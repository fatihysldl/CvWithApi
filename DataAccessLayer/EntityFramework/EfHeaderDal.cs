using DataAccessLayer.abstracts;
using DataAccessLayer.concrete;
using DataAccessLayer.concrete.repositories;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfHeaderDal : genericRepositoryDal<header>, IHeaderDal
    {
        public EfHeaderDal(context context) : base(context)
        {
        }
    }
}
