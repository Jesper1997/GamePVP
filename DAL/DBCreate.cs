using System;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Items;
using MySQL.Data.EntityFrameworkCore;

namespace Dal
{
    public class DBCreate : DbContext
    {
        internal protected DbSet<User> user { get; set; }
        internal protected DbSet<Character> character {get; set;}
        internal protected DbSet<Equipment> equipment { get; set; }
        internal protected DbSet<Attack> attacks { get; set; }

        public void EnsureDbIsCreated()
        {
            using (var context = new DBCreate())
            {
                context.Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(StringStorage.DbString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //To CreateTable
            base.OnModelCreating(builder);
            builder.Entity<User>();
            builder.Entity<Character>();
            builder.Entity<Equipment>();
            builder.Entity<Attack>();
        }
    }
}
