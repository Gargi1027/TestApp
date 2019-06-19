using Microsoft.EntityFrameworkCore;
using TestApp.API.Models;

namespace TestApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        //The name of DbSet will be the name of new database in SQL
        public DbSet<Value> Values { get; set; }
    }
}