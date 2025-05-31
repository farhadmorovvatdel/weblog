using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weblog.Domain.Entites;

namespace Weblog.Infrastructure
{
    public static class InitialData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(c => c.CreatedDate)
    .HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Category>().HasData
                (
                    new Category { Id = new Guid("55935106-7b27-4c06-af49-0ea8ea9cfc3c"), Name = "موبایل", },
                    new Category { Id = new Guid("40c8495f-252d-485d-a131-3cc5e02c8c93"), Name = "لپ تاپ" }

                );
            
        }
    }
}
