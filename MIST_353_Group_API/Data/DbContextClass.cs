
using MIST_353_Group_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace MIST_353_Group_API.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<FireWarning> FireWarning {get; set;}
        public DbSet<Location> Location { get; set;}
        public DbSet<Weather> Weather { get; set;}



    } 
}
