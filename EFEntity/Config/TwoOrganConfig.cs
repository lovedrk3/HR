using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    public class TwoOrganConfig : EntityTypeConfiguration<Twoorgan>
    {
        public TwoOrganConfig()
        {
            this.ToTable(nameof(Twoorgan));
            this.HasKey(e => e.Tid);
        }
    }
}
