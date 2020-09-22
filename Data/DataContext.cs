using DesafioMutant.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioMutant.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Contact> Contact { get; set; }
    }
}
