using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace C_.EF
{
    public class AppDbContextBuilder : IDesignTimeDbContextFactory<AppDbContext> 
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = @"server=.,5433;Database=AutoLotSamples;User Id=sa;Password=P@ssw0rd;Encrypt=False;";
            optionsBuilder.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
            Console.WriteLine(connectionString);
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}