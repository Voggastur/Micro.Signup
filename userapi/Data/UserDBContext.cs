#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using userapi.Models;

    public class UserDBContext : DbContext
    {
        public UserDBContext (DbContextOptions<UserDBContext> options)
            : base(options)
        {
        }

        public DbSet<userapi.Models.User> User { get; set; }

        public DbSet<userapi.Models.Blog> Blog { get; set; }
    }
