using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    public class TreeorganConfig : EntityTypeConfiguration<Treeorgan>
    {
        public TreeorganConfig()
        {
            this.ToTable(nameof(Treeorgan));
            this.HasKey(e => e.Thid);
        }
    }
}
