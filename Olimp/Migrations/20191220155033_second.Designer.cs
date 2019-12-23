﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Olimp.Dal.Dbcontext;

namespace Olimp.Migrations
{
    [DbContext(typeof(OlimpPricesContext))]
    [Migration("20191220155033_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Olimp.Dal.OlimpPrices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("AWAY")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_0_0")
                        .HasColumnName("AWAY_HDP 0,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_0_25")
                        .HasColumnName("AWAY_HDP 0,25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_0_5")
                        .HasColumnName("AWAY_HDP 0,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_0_75")
                        .HasColumnName("AWAY_HDP 0,75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_1_0")
                        .HasColumnName("AWAY_HDP 1,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_1_25")
                        .HasColumnName("AWAY_HDP 1,25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_1_5")
                        .HasColumnName("AWAY_HDP 1,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_2_0")
                        .HasColumnName("AWAY_HDP 2,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_2_25")
                        .HasColumnName("AWAY_HDP 2,25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_2_5")
                        .HasColumnName("AWAY_HDP 2,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_2_75")
                        .HasColumnName("AWAY_HDP 2,75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_3_0")
                        .HasColumnName("AWAY_HDP 3,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_3_25")
                        .HasColumnName("AWAY_HDP 3,25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP_3_5")
                        .HasColumnName("AWAY_HDP 3,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__0_25")
                        .HasColumnName("AWAY_HDP -0,25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__0_5")
                        .HasColumnName("AWAY_HDP -0,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__0_75")
                        .HasColumnName("AWAY_HDP -0,75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__1_0")
                        .HasColumnName("AWAY_HDP -1,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__1_5")
                        .HasColumnName("AWAY_HDP -1,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__1_5_computed")
                        .HasColumnName("AWAY_HDP -1,5_computed_")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__1_5_disc")
                        .HasColumnName("AWAY_HDP -1,5_disc")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__1_75")
                        .HasColumnName("AWAY_HDP -1,75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__2_0")
                        .HasColumnName("AWAY_HDP -2,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__2_5")
                        .HasColumnName("AWAY_HDP -2,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__2_75")
                        .HasColumnName("AWAY_HDP -2,75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__3_0")
                        .HasColumnName("AWAY_HDP -3,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("AWAY_HDP__3_5")
                        .HasColumnName("AWAY_HDP -3,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<string>("AwayTeam");

                    b.Property<decimal?>("DRAW")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("DRAWAWAY")
                        .HasColumnType("decimal(18,7)");

                    b.Property<string>("DateAdded");

                    b.Property<string>("EventId");

                    b.Property<decimal?>("HOME")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOMEAWAY")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOMEDRAW")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_0_0")
                        .HasColumnName("HOME_HDP 0,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_0_25")
                        .HasColumnName("HOME_HDP 0,25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_0_5")
                        .HasColumnName("HOME_HDP 0,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_0_75")
                        .HasColumnName("HOME_HDP 0,75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_1_0")
                        .HasColumnName("HOME_HDP 1,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_1_5")
                        .HasColumnName("HOME_HDP 1,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_1_5_computed")
                        .HasColumnName("HOME_HDP 1,5_computed_")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_1_5_disc")
                        .HasColumnName("HOME_HDP 1,5_disc")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_1_75")
                        .HasColumnName("HOME_HDP 1,75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_2_0")
                        .HasColumnName("HOME_HDP 2,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_2_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_2_75")
                        .HasColumnName("HOME_HDP 2,75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_3_0")
                        .HasColumnName("HOME_HDP 3,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP_3_5")
                        .HasColumnName("HOME_HDP 3,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__0_25")
                        .HasColumnName("HOME_HDP -0,25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__0_5")
                        .HasColumnName("HOME_HDP -0,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__0_75")
                        .HasColumnName("HOME_HDP -0,75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__1_0")
                        .HasColumnName("HOME_HDP -1,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__1_25")
                        .HasColumnName("HOME_HDP -1,25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__1_5")
                        .HasColumnName("HOME_HDP -1,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__2_0")
                        .HasColumnName("HOME_HDP -2,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__2_25")
                        .HasColumnName("HOME_HDP -2,25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__2_5")
                        .HasColumnName("HOME_HDP -2,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__2_75")
                        .HasColumnName("HOME_HDP -2,75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__3_0")
                        .HasColumnName("HOME_HDP -3,0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__3_25")
                        .HasColumnName("HOME_HDP -3,25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("HOME_HDP__3_5")
                        .HasColumnName("HOME_HDP -3,5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<string>("HomeTeam");

                    b.Property<bool?>("IsLive");

                    b.Property<string>("LeagueName");

                    b.Property<string>("StartTime");

                    b.Property<decimal?>("T1O_0_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_0_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_1_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_1_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_1_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_1_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_2_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_2_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_2_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_2_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_3_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_3_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_3_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_3_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_4_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_4_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1O_4_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_0_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_0_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_1_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_1_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_1_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_1_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_2_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_2_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_2_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_2_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_3_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_3_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_3_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_3_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_4_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_4_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T1U_4_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_0_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_0_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_1_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_1_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_1_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_1_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_2_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_2_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_2_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_2_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_3_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_3_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_3_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_3_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_4_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_4_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2O_4_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_0_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_0_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_1_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_1_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_1_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_1_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_2_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_2_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_2_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_2_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_3_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_3_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_3_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_3_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_4_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_4_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("T2U_4_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_0_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_0_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_1_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_1_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_1_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_1_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_2_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_2_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_2_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_2_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_3_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_3_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_3_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_3_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_4_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_4_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_4_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_4_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_5_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_5_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_5_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_5_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_6_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_6_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TO_6_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_0_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_0_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_1_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_1_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_1_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_1_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_2_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_2_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_2_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_2_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_3_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_3_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_3_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_3_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_4_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_4_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_4_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_4_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_5_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_5_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_5_5")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_5_75")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_6_0")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_6_25")
                        .HasColumnType("decimal(18,7)");

                    b.Property<decimal?>("TU_6_5")
                        .HasColumnType("decimal(18,7)");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });
#pragma warning restore 612, 618
        }
    }
}
