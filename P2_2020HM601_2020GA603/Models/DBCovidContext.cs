﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace P2_2020HM601_2020GA603.Models
{

    public class DBCovidContext : DbContext
    {
        public DBCovidContext(DbContextOptions<DBCovidContext> options) : base(options)
        {
        }

        public DbSet<Departamento> departamentos { get; set; }

        public DbSet<Generos> generos { get; set; }

        public DbSet<CasosReportados> casosReportados { get; set; }

    }
}
