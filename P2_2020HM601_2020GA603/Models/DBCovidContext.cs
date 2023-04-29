using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace P2_2020HM601_2020GA603.Models
{

    public class DBCovidContext : DbContext
    {
        public DBCovidContext(DbContextOptions<DBCovidContext> options) : base(options)
        {
        }

        //public DbSet<Marcas> marcas { get; set; }
    }
}
