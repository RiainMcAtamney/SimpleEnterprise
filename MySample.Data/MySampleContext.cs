namespace MySample.Data
{
    using Business;
    using System.Data.Entity;

    public class MySampleContext : DbContext
    {       
        public MySampleContext(): base("MySample")
        {
            Database.SetInitializer<MySampleContext>(new CreateDatabaseIfNotExists<MySampleContext>());
        }
                
        public DbSet<Company> Companies { get; set; }

        public DbSet<Product> Products { get; set; }
    }
    
}