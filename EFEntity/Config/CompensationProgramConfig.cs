using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity.Config
{
   public class CompensationProgramConfig : EntityTypeConfiguration<CompensationProgram>
    {
        public CompensationProgramConfig()
        {
            this.ToTable(nameof(CompensationProgram));
            this.HasKey(e => e.Cpid);
        }
    }
}
