using MailingList.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MailingList.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
        public DbSet<Member> Members { get; set;}
    }
}