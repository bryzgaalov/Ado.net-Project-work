using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_ADONET_1
{

    class MyDbContext : DbContext
    {

        public MyDbContext() : base("SqlConnection")
        {

        }
        public DbSet<xDataDoc> dataDocs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

}
