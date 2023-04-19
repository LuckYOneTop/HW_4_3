using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HW_4_3
{
    internal class EmployeeProject
    {
        public int Id { get; set; }
        public decimal Rate { get; set; }
        public DateTime StardedDate { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder
                .ToTable("EmployeeProject")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("EmployeeProjectId")
                .ValueGeneratedNever();
            builder.Property(p => p.Rate)
               .HasColumnType("money");
        }
    }
}
