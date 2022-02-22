using Microsoft.EntityFrameworkCore;
namespace ApiSqlAzure.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<contacts> ContactSet{
            get;
            set;
        }
    }
}