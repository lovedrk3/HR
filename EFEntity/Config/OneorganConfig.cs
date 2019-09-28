using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    public class OneorganConfig : EntityTypeConfiguration<Oneorgan>
    {
        public OneorganConfig()
        {
            this.ToTable(nameof(Oneorgan));
            this.HasKey(e => e.Oid);
        }
    }
}
