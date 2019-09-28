using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    public class AttributeNameConfig :EntityTypeConfiguration<AttributeName>
    {
        public AttributeNameConfig()
        {
            this.ToTable(nameof(AttributeName));
            this.Property(e => e.ANName).HasMaxLength(50);
            this.HasKey(e => e.ANID);
        }
    }
}
