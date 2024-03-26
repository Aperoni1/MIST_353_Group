
using MIST_353_Group_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace MIST_353_Group_API.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {

        }
        public DbSet<FireWarning> FireWarning {get; set;}
        public DbSet<Location> Location { get; set;}
        public DbSet<Weather> Weather { get; set;}



    } 
}
