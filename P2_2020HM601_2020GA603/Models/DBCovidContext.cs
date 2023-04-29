using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using P2_2020HM601_2020GA603.Models;

namespace P2_2020HM601_2020GA603.Models
{

    public class DBCovidContext : DbContext
    {
        public DBCovidContext(DbContextOptions<DBCovidContext> options) : base(options)
        {
        }
               
        public DbSet<Departamento> departamentos { get; set; }       
        public DbSet<Genero> generos { get; set; }
    }
}
