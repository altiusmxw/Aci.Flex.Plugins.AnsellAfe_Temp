using Aci.Flex.Core;
using Aci.Flex.Plugins.AnsellAfe.Server.DataModel;
using Aci.Flex.Plugins.AnsellAfe.Server.DataModel.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aci.Flex.Plugins.AnsellAfe.Server
{
    public class AnsellAfeContext : FlexDbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Afe> Afes { get; set; }
        public DbSet<AdditionalApprover> AdditionalApprovers { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<FactBudget> FactBudgets { get; set; }
        public DbSet<FactFinancial> FactFinancials { get; set; }
        public DbSet<Function> Functions { get; set; }
        public DbSet<Nature> Natures { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Authorization> Authorizations { get; set; }
        public DbSet<AuthorizationCategory> AuthorizationCategories { get; set; }

        public AnsellAfeContext()
            : base()
        {
            //Database.SetInitializer<AnsellAfeContext>(null);
            Database.SetInitializer<AnsellAfeContext>(new AnsellAfeInitializer());
        }

        public AnsellAfeContext(string connectionString, string schemaName)
            : base(connectionString, schemaName)
        {
            //Database.SetInitializer<AnsellAfeContext>(null);
            Database.SetInitializer<AnsellAfeContext>(new AnsellAfeInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(SchemaName);

            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new AfeMap());
            modelBuilder.Configurations.Add(new AdditionalApproverMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new DivisionMap());
            modelBuilder.Configurations.Add(new ExchangeRateMap());
            modelBuilder.Configurations.Add(new FactBudgetMap());
            modelBuilder.Configurations.Add(new FactFinancialMap());
            modelBuilder.Configurations.Add(new FunctionMap());
            modelBuilder.Configurations.Add(new NatureMap());
            modelBuilder.Configurations.Add(new PurposeMap());
            modelBuilder.Configurations.Add(new SiteMap());
            modelBuilder.Configurations.Add(new AuthorizationMap());
            modelBuilder.Configurations.Add(new AuthorizationCategoryMap());
        }
    }
}
