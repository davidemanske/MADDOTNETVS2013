using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MADDOTNET.Init.Models
{
    public class MADDOTNETDbContext : DbContext
    {

        public DbSet<Person> People { get; set; }
    }
}