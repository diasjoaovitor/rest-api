﻿using Microsoft.EntityFrameworkCore;

namespace RestAPI.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options)
            : base(options) { }

        public DbSet<Person> Persons { get; set; }
    }
}
