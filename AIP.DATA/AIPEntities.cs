using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.Model;

namespace AIP.DATA
{
    public class AIPEntities : DbContext
    {
        public AIPEntities() : base("AIPEntities") { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<News> NewsData { get; set; }
        public DbSet<Activity> Activities { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
