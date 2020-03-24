using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;

namespace Onion.Infrastructure.MsSqlService.EntityFramework
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=db-mssql;Initial Catalog=s17628;Integrated Security=True");
        }

        public virtual DbSet<Student> Students { get; set; }
    }
}