using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weblog.Domain.Entites;

namespace Weblog.Infrastructure.Context
{
    public class AppDbContext:IdentityDbContext<IdentityUser,IdentityRole,string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            InitialData.Seed(builder);
            base.OnModelCreating(builder);
        }
        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
