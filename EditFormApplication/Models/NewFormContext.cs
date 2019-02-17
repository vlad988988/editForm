using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EditFormApplication.Models
{
    public class NewFormContext : DbContext
    {
        public DbSet<NewForm> NewForms { get; set; }
        public DbSet<Field> Fields { get; set; }
    }
}