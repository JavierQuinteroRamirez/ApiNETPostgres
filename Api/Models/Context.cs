using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<MOD_UserTable> usr_user { get; set; }       
    }
}
