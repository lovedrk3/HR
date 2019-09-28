using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    class PostClassifyConfig : EntityTypeConfiguration<PostClassify>
    {
        public PostClassifyConfig()
        {
            this.ToTable(nameof(PostClassify));
            this.HasKey(e => e.PostClassifyId);
            this.Property(e => e.PostClassifyName).HasMaxLength(100);
        }
    }
}
