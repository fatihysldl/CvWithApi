using EntityLayer.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.concrete
{
    public class context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= Fatih\\SQLEXPRESS; initial catalog=ApiCvDatas; integrated security=true; TrustServerCertificate=True;");
        }

        public DbSet <about> abouts { get; set; }
        public DbSet <contact> contacts { get; set; }
        public DbSet <header> headers{ get; set; }
        public DbSet <project> projects{ get; set; }
        public DbSet<education> educations { get; set; }
      //  public DbSet<resume> resumes { get; set; }
        public DbSet <experience> experiences{ get; set; }
    }
}
