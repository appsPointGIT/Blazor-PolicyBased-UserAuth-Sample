using BlazorAuthApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorAuthApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var initialUserAccounts = new List<UserAccount>()
            {
                new(){Id=1, UserName="user1", Password="user1"},
                new(){Id=2, UserName="user2", Password="user2"},
                new(){Id=3, UserName="user3", Password="user3"},
                new(){Id=4, UserName="user4", Password="user4"},
                new(){Id=5, UserName="user5", Password="user5"},
            };
            modelBuilder.Entity<UserAccount>().HasData(initialUserAccounts);

            var initialUserAccountPolicies = new List<UserAccountPolicy>()
            {
                /*User1 Policies */
                new(){Id=1, UserAccountId=1, UserPolicy=UserPolicy.VIEW_PRODUCT.ToString(), IsEnabled=true},
                new(){Id=2, UserAccountId=1, UserPolicy=UserPolicy.ADD_PRODUCT.ToString(), IsEnabled=true},
                new(){Id=3, UserAccountId=1, UserPolicy=UserPolicy.EDIT_PRODUCT.ToString(), IsEnabled=true},
                new(){Id=4, UserAccountId=1, UserPolicy=UserPolicy.DELETE_PRODUCT.ToString(), IsEnabled=true},
                
                /*User2 Policies */
                new(){Id=5, UserAccountId=2, UserPolicy=UserPolicy.VIEW_PRODUCT.ToString(), IsEnabled=true},
                new(){Id=6, UserAccountId=2, UserPolicy=UserPolicy.ADD_PRODUCT.ToString(), IsEnabled=false},
                new(){Id=7, UserAccountId=2, UserPolicy=UserPolicy.EDIT_PRODUCT.ToString(), IsEnabled=false},
                new(){Id=8, UserAccountId=2, UserPolicy=UserPolicy.DELETE_PRODUCT.ToString(), IsEnabled=false},
                
                /*User3 Policies */
                new(){Id=9, UserAccountId=3, UserPolicy=UserPolicy.VIEW_PRODUCT.ToString(), IsEnabled=true},
                new(){Id=10, UserAccountId=3, UserPolicy=UserPolicy.ADD_PRODUCT.ToString(), IsEnabled=true},
                new(){Id=11, UserAccountId=3, UserPolicy=UserPolicy.EDIT_PRODUCT.ToString(), IsEnabled=false},
                new(){Id=12, UserAccountId=3, UserPolicy=UserPolicy.DELETE_PRODUCT.ToString(), IsEnabled=false},
                
                /*User4 Policies */
                new(){Id=13, UserAccountId=4, UserPolicy=UserPolicy.VIEW_PRODUCT.ToString(), IsEnabled=true},
                new(){Id=14, UserAccountId=4, UserPolicy=UserPolicy.ADD_PRODUCT.ToString(), IsEnabled=true},
                new(){Id=15, UserAccountId=4, UserPolicy=UserPolicy.EDIT_PRODUCT.ToString(), IsEnabled=true},
                new(){Id=16, UserAccountId=4, UserPolicy=UserPolicy.DELETE_PRODUCT.ToString(), IsEnabled=false},
                
                /*User5 Policies */
                new(){Id=17, UserAccountId=5, UserPolicy=UserPolicy.VIEW_PRODUCT.ToString(), IsEnabled=false},
                new(){Id=18, UserAccountId=5, UserPolicy=UserPolicy.ADD_PRODUCT.ToString(), IsEnabled=false},
                new(){Id=19, UserAccountId=5, UserPolicy=UserPolicy.EDIT_PRODUCT.ToString(), IsEnabled=false},
                new(){Id=20, UserAccountId=5, UserPolicy=UserPolicy.DELETE_PRODUCT.ToString(), IsEnabled=false},

            };
            modelBuilder.Entity<UserAccountPolicy>().HasData(initialUserAccountPolicies);

        }

        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<UserAccountPolicy> UserAccountPolicies { get; set; }

    }
}
