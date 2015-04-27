using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;

namespace Registar.DataLayer
{
    public class BikeConfiguration : EntityTypeConfiguration<Bike>
    {
        public BikeConfiguration()
        {
            this.ToTable("Bikes", "Data")
            //this.ToTable("Bikes")
                
                //.HasKey(x => new {Id = x.BikeId, Colour = x.Colour});
                .HasKey(p => p.BikeId);

            this.Property(p => p.BikeId)
                .HasColumnName("Id");

            this.Property(p => p.RegNumber)
               .HasColumnName("RegNumber");

            this.Property(p => p.Producer)
               .HasColumnName("Producer");

            this.Property(p => p.Model)
               .HasColumnName("Model");
            this.Property(p => p.Colour)
               .HasColumnName("Color");

            //this.Ignore(p => p.IgnoreMe);
        }
    }
}
