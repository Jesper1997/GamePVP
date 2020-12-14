using System;
using System.Collections.Generic;
using System.Text;
using IDal.DTO;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;

namespace DAL
{
    class DBCreate: DbContext
    {
        //Interface proberen
        internal protected DbSet<IDal.DTO.DTOUserFolder.DTOUser> user { get; set; }
        internal protected DbSet<IDal.DTO.DTOUserFolder.DTOCharacter> Characters { get; set; }

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
            //Tabel van de user
            base.OnModelCreating(builder);
            builder.Entity<IDal.DTO.DTOUserFolder.DTOUser>
                (entity =>
                {
                    entity.HasKey(e => e.Name);
                    entity.Property(e => e.PW).IsRequired();
                    entity.Property(e => e.Points);
                }
                );
            //TODO Entity Automatisch aan laten maken
            //Tabel van de Character
            builder.Entity<IDal.DTO.DTOUserFolder.DTOCharacter>
                (entity =>
                {
                    entity.HasKey(e => e.Id);
                    entity.Property(e => e.MaxHP);
                    entity.Property(e => e.HP);
                    entity.Property(e => e.BaseAttack);
                    entity.Property(e => e.AttackTotalValue);
                    entity.Property(e => e.BaseDefence);
                    entity.Property(e => e.DefenceTotalValue);
                    entity.Property(e => e.BaseSpecialAttack);
                    entity.Property(e => e.SpecialAttackTotlaValue);
                    entity.Property(e => e.BaseAgility);
                    entity.Property(e => e.BaseAgility);
                    entity.HasOne(d => d.DTOUser)
                          .WithMany(p => p.Chachters)
                          .IsRequired();
                }
                );
            
        }
    }
}
