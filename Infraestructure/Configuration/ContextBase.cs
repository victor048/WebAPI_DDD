using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Configuration
{
    public class ContextBase : IdentityDbContext<AplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options):base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }

        public DbSet<AplicationUser> AplicationUsers { get; set; }

        public string ObterStringConexao()
        {
            return "Data Source=(localdb)\\MSSQLLocalDB;database= API_DDD;Integrated Security=True;";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}
