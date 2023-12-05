

namespace Infarstuructre.Data
{
    public class POSDbcontext: IdentityDbContext
    {
        public POSDbcontext(DbContextOptions<POSDbcontext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {



            base.OnModelCreating(builder);

            //في المكان هاد كمل خصائص الجداول نضيفها فهذا المكان 

         //   builder.Entity<TbUser>()
         //.Property(b => b.dateTimeInsert)
         //.HasDefaultValueSql("getdate()");
         //   builder.Entity<TbUser>()
         //  .Property(b => b.CurrentState)
         //  .HasDefaultValueSql("((1))");

        }
        //public DbSet<TbUser> TBUsers { get; set; }

    }
}
