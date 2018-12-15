using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoApp.Models
{
    //A MicroSoft Entity Framework-jet be kell tolteni egy nuget csomaggal,
    //hogy a DbContext-et tudjuk hasznalni
    public class Db : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
    }

    public class DbAircraft : DbContext
    {
        public DbSet<Aircraft> AirCrafts { get; set; }
    }
}