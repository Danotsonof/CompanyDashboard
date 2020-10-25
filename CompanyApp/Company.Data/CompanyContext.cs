using Company.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Company.Data
{
    /// <summary>
    /// an instantiated context class that represents a session with the database
    /// used to query and communicate with the database
    /// </summary>
    public class CompanyContext : DbContext
    {
        /// <summary>
        /// The variable that holds the connection string
        /// </summary>
        private const string ConnectionString = @"Server=localhost\SQLEXPRESS;Database=CompanyDB;Trusted_Connection=True;";
        //private const string ConnectionString = @"Server=.;Database=CompanyDB;Trusted_Connection=True;";
        
        /// <summary>
        /// DbSet for the Employee Entity
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
        
        /// <summary>
        /// DbSet for the Department Entity
        /// </summary>
        public DbSet<Department> Departments { get; set; }
        
        /// <summary>
        /// Connecting to the sql server
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                ConnectionString);
        }
        /// <summary>
        /// Configure Cascade Delete using Fluent API
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany<Employee>(c => c.Employees)
                .WithOne(s => s.Departments)
                .HasForeignKey(s => s.DEPARTMENTID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
