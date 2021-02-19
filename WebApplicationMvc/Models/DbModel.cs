using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationMvc.Models
{
    public class DbModel: DbContext
    {
        public DbModel() : base("name=ConnectDbUser") { }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Name)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(u => u.EmailId)
                .HasColumnName("EmailId")
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(u => u.Gender)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(u => u.Subscription)
                .IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}