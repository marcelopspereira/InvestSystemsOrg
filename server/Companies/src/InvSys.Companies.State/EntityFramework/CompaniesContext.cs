﻿using InvSys.Companies.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace InvSys.Companies.State.EntityFramework
{
    public class CompaniesContext : DbContext
    {
        private readonly IConfigurationRoot _config;

        public CompaniesContext() { }

        public CompaniesContext(IConfigurationRoot config, DbContextOptions options)
            : base(options)
        {
            _config = config;
        }

        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Companies;Integrated Security=SSPI;integrated security=true;MultipleActiveResultSets=True;");
            //optionsBuilder.UseSqlServer(_config["ConnectionStrings:CompaniesContextConnection"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(ConfigureCompany);
            modelBuilder.Entity<CompanyTranslation>(ConfigureCompanyTranslation);

        }

        private static void ConfigureCompany(EntityTypeBuilder<Company> builder)
        {
            builder.HasMany(c => c.Translations).WithOne(t => t.Company).HasForeignKey(t => t.CompanyId);
        }

        private static void ConfigureCompanyTranslation(EntityTypeBuilder<CompanyTranslation> builder)
        {
            builder.HasKey(t => new { t.CompanyId, t.Culture });
        }
    }
}
