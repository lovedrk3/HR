using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    class AttributeTypeConfig: EntityTypeConfiguration<AttributeType>
    {
        public AttributeTypeConfig()
        {
            this.ToTable(nameof(AttributeType));
            this.Property(e => e.ATName).HasMaxLength(50);
            this.HasKey(e=>e.ATID);
        }
    }
}
