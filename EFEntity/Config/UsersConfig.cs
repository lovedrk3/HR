using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    public class UsersConfig: EntityTypeConfiguration<Users>
    {
        public UsersConfig()
        {
            this.ToTable(nameof(Users));
            this.Property(e => e.uName).HasMaxLength(50);
            this.HasKey(e=>e.uID);
        }
    }
}
