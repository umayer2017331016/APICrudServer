﻿using Microsoft.EntityFrameworkCore;

namespace APICrud.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) 
        { 
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
