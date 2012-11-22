using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Topicus_Ideeënbank.Models
{
    public class IdeeenbankContext : DbContext
    {
        public IdeeenbankContext()
            : base("IdeeenbankContext")
        {

        }


        public DbSet<Reactie> Reactie { get; set; }
        public DbSet<Kudo> Kudo { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Idee> Idee { get; set; }
    }

        


    
}