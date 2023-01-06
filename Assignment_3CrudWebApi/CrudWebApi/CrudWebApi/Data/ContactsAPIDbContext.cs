using CrudWebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudWebApi.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
