using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegionalVIC.Models.DB
{
    public partial class RegionalVICContext : DbContext
    {
        public RegionalVICContext()
        {
        }

        public RegionalVICContext(DbContextOptions<RegionalVICContext> options)
            : base(options)
        {
        }

        // Unable to generate entity type for table 'dbo.CRITBL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGAMAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LGATBL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PPLTBL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.REGMAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RTRTBL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SBBMAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.STTMAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-Comm-Area-Part1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-Comm-Area-Part2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-Comm-LGAs-Part1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-Comm-LGAs-Part2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-Comm-Region-Part1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-Comm-Region-Part2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-Criminal-Incidents'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-Criminal-Incidents-2018-R'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-LGA-Code'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-PPL-Density-2017'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-Rental-Report'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-Rental-Report-2018-R'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tmp-VicPost'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RegionalVIC;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
