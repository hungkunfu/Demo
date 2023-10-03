﻿namespace Demo.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        { 
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetails>  EmployeeDetails { get; set; }
    }
}
