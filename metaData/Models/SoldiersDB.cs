using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace metaData.Models
{
    public class SoldiersDB : DbContext
    {
        public DbSet<Soldier> Soldiers { get; set; }
    }
}