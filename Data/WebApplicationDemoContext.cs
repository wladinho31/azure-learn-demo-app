using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationDemo.Entities;

namespace WebApplicationDemo.Data
{
    public class WebApplicationDemoContext : DbContext
    {
        public WebApplicationDemoContext (DbContextOptions<WebApplicationDemoContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationDemo.Entities.Country> Country { get; set; }

        public DbSet<WebApplicationDemo.Entities.Person> Person { get; set; }
    }
}
