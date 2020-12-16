using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finals3.Model
{
   
        public class ExpensesDatabase : DbContext
        {
            public DbSet<Expense> Items { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                //
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog= ExpenseDatabase;Integrated Security=True;");
            }

        
    }
}
