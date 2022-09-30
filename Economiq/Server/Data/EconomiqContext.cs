using Economiq.Shared.Extensions;
using Economiq.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Economiq.Server.Data
{
    public class EconomiqContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpensesCategory { get; set; }
        public DbSet<Recipient> Recipients { get; set; }

        public DbSet<Budget> Budgets { get; set; }

        public EconomiqContext()
        {

        }

        public EconomiqContext(DbContextOptions<EconomiqContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            //Primary Keys
            modelbuilder.Entity<Expense>()
                .HasKey(e => e.Id);
            modelbuilder.Entity<User>()
                .HasKey(u => u.Id);
            modelbuilder.Entity<ExpenseCategory>()
                .HasKey(ec => ec.Id);
            modelbuilder.Entity<Recipient>()
                .HasKey(r => r.Id);
            modelbuilder.Entity<Email>()
                .HasKey(c => new { c.UserNavId, c.Mail });
            modelbuilder.Entity<Budget>()
                .HasKey(b => b.Id);
            //Relations
            modelbuilder.Entity<Expense>()
                .HasOne(u => u.UserNav)
                .WithMany(e => e.UserExpensesNav)
                .HasForeignKey(e => e.UserNavId)
                .OnDelete(DeleteBehavior.NoAction);
            modelbuilder.Entity<Budget>()
                .HasOne(u => u.User)
                .WithMany(b => b.Budgets)
                .HasForeignKey(b => b.UserNav)
                .OnDelete(DeleteBehavior.NoAction);
            modelbuilder.Entity<Expense>()
                .HasOne(b => b.Budget)
                .WithMany(e => e.Expenses)
                .HasForeignKey(b => b.BudgetNav)
                .OnDelete(DeleteBehavior.NoAction);
            modelbuilder.Entity<User>()
                .HasMany(e => e.UserExpensesNav)
                .WithOne(u => u.UserNav)
                .OnDelete(DeleteBehavior.Cascade);
            modelbuilder.Entity<Expense>()
                .HasOne(e => e.CategoryNav)
                .WithMany(e => e.ExpensesNav)
                .HasForeignKey(e => e.CategoryNavId)
                .OnDelete(DeleteBehavior.NoAction);
            modelbuilder.Entity<ExpenseCategory>()
                .HasMany(ec => ec.UserNav)
                .WithMany(u => u.ExpensesCategoryNav);
            modelbuilder.Entity<Recipient>()
                .HasOne(ur => ur.UserNav)
                .WithMany(re => re.RecipientNav)
                .HasForeignKey(e => e.UserNavId)
                .OnDelete(DeleteBehavior.NoAction);
            modelbuilder.Entity<Expense>()
                .HasOne(re => re.RecipientNav)
                .WithMany(ex => ex.ExpenseNav)
                .HasForeignKey(e => e.RecipientNavId)
                .OnDelete(DeleteBehavior.NoAction);



            modelbuilder.Seed();
        }

    }
}
