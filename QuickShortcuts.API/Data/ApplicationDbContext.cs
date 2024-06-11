using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuickShortcuts.API.Models.Entities;


namespace QuickShortcuts.API.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public string DbPath { get; private set; }
        public ApplicationDbContext()
        {
            DbPath = "QuickShortcuts.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Shortcut> Shortcuts { get; set; }
    }
}
