using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
   public class CpsssConfig : EntityTypeConfiguration<Cpsss>
    {
        public CpsssConfig()
        {
            this.ToTable(nameof(Cpsss));
            this.HasKey(e => e.id);
        }
    }
}
