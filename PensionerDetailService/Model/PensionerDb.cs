using Microsoft.EntityFrameworkCore;

namespace PensionerDetailService.Model
{
    public class PensionerDb : DbContext
    {
        public PensionerDb()
        {

        }

        public PensionerDb(DbContextOptions<PensionerDb> options) : base(options)
        {

        }

        public DbSet<PensionerDetail> Pensioners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:pmsdatabase.database.windows.net,1433;Initial Catalog=PentionerDetails;Persist Security Info=False;User ID=azureroot;Password=abhinav@195;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        }
    }
}
