using EntityLayer.Conctete;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class AppDBContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
