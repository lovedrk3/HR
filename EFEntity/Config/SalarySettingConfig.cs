using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
    public class SalarySettingConfig : EntityTypeConfiguration<SalarySetting>
    {
        public SalarySettingConfig()
        {
            this.ToTable(nameof(SalarySetting));
            this.Property(e => e.SName).HasMaxLength(50);
            this.HasKey(e => e.SID);
        }
    }
}
