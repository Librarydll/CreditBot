using CreditBot.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CreditBot.Infrastructure
{
    public class CreditBotDbContext : DbContext
    {
        public CreditBotDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<CreditHistory> CreditHistories { get; set; }
        public DbSet<Word> Words { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
