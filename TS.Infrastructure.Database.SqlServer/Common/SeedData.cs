using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Common
{
    public static class SeedData
    {
        public static void UserAndRoleSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(new List<IdentityRole>
                {
                    new IdentityRole
                    {
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new IdentityRole
                    {
                        Name = "Costumer",
                        NormalizedName = "CUSTOMER"
                    }
                });


            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1, // primary key
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "123"),
                    IsActive = true
                },
                new User
                {
                    Id = 2, // primary key
                    UserName = "hamid",
                    NormalizedUserName = "STAFF",
                    PasswordHash = hasher.HashPassword(null, "123"),
                    IsActive = true
                }
            );
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new List<IdentityUserRole<int>>
            {


                    new IdentityUserRole<int>
                    {
                        RoleId = 1, // for admin username
                        UserId = 1  // for admin role
                    },
                    new IdentityUserRole<int>
                    {
                        RoleId = 2, // for staff username
                        UserId = 2  // for staff role
                    }
            });
        }
    }

}
