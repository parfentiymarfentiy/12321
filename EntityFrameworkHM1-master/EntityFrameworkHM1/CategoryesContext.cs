using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkHM1
{
    internal class CategoryesContext : DbContext
    {
        public DbSet<Categoryes> Categoryess  { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=C:\Users\Brain\source\repos\EntityFrameworkHM1\EntityFrameworkHM1\Database1.mdf;
                                        Integrated Security=True";

            options.UseSqlServer(connectionString);
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
     modelBuilder.Entity<Categoryes>()
         .Property(e => e.Example)
         .HasConversion(
             v => string.Join(',', v), // Конвертируем список в строку "1,2,3" для базы
             v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList() // Обратно в список
         );
 }
    }
}
