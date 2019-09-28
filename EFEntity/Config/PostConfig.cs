using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    public class PostConfig : EntityTypeConfiguration<Post>
    {
        public PostConfig()
        {
            this.ToTable(nameof(Post));
            this.HasKey(e => e.PostId);
            this.Property(e => e.PostName).HasMaxLength(50);
        }
    }
}
