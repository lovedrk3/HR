using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EFEntity.Config
{
    class StudentConfig: EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            this.ToTable(nameof(Student));
            this.Property(e => e.Name).HasMaxLength(50);
        }
    }
}
