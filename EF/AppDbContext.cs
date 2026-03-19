using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_.EF.Objets;
using Microsoft.Extensions.Options;

namespace C_.EF
{
    public class AppDbContext : DbContext
    {
        //se agregan las propiedades (entidades)
        public DbSet<obj2> obj2s {get;set;}
        public DbSet<Obje3> Obje3s { get; set; } //Estas dos ultimas al ser TPT se deben especificar en el modelbuilder
        public DbSet<obj4> Obj4s { get; set; } 

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        // Fluent API calls go here
        //modo TPT
        modelBuilder.Entity<Obje3>().ToTable("obje3s");
        modelBuilder.Entity<obj4>().ToTable("obj4s");

        }

        //Esto debe ir en un service 
        static void savechanges()
        {
            //se trae el contexto 
            var context = new AppDbContext(); 
            context.SaveChanges();
        }
        
        //Esto tambien
        static void transactionChanges()
        {

            var context = new AppDbContext(); 

            var transaction = context.Database.BeginTransaction();

            transaction.CreateSavepoint("Check1");
            try
            {
                //codigo
                context.SaveChanges();
                transaction.Commit();
            }
            catch (System.Exception)
            {
                transaction.RollbackToSavepoint("Check1");
            }
        }
    }
}