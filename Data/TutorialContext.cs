using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial.Data
{
    public class TutorialContext : DbContext
    {
        public TutorialContext() {}
        public TutorialContext(DbContextOptions<TutorialContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TutorialDB;Trusted_Connection=True;");
            }
        }

    }
}
