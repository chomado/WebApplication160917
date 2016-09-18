using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication160917.Models
{
    public class ChomadoContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}