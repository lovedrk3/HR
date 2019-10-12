using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
   public class CompensationTandardsConfig : EntityTypeConfiguration<CompensationTandards>
    {
        public CompensationTandardsConfig()
        {
            this.ToTable(nameof(CompensationTandards));
            this.HasKey(e => e.Ctid);
        }
    }
}
