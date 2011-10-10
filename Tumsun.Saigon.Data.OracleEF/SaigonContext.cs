using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Entity;
using Tumsun.Saigon.Domain.Model;
using System.ComponentModel.DataAnnotations;

namespace Tumsun.Saigon.Data.OracleEF
{
    /// <summary>
    /// 
    /// </summary>
    public class SaigonContext: DbContext
    {
        //private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["SaigonEntities"].ConnectionString;

        public SaigonContext()
            : base(ConnectionString)
        {

        }

        public DbSet<CatalogVehicle> CatalogVehicles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Fluent API for CatalogVehicle entity

            modelBuilder.Entity<CatalogVehicle>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<CatalogVehicle>()
                .Property(p => p.Id);

            modelBuilder.Entity<CatalogVehicle>()
                .Property(p => p.MakeId)
                .IsRequired();

            modelBuilder.Entity<CatalogVehicle>()
                .Property(p => p.ModelId)
                .IsRequired();

            #endregion

            base.OnModelCreating(modelBuilder);
        }

    }

}
