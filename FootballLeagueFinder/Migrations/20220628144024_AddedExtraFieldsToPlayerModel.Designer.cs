// <auto-generated />
using FootballLeagueFinder.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FootballLeagueFinder.Migrations
{
    [DbContext(typeof(FootballDbContext))]
    [Migration("20220628144024_AddedExtraFieldsToPlayerModel")]
    partial class AddedExtraFieldsToPlayerModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FootballLeagueFinder.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Leagues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The West Kent League, is a football competition based in Kent, England. The league has seven senior divisions – a Premier Division, Division One East and West, Division Two East and West and Division Three East and West. It sits below the Southern Counties East League Division One (step 6 of the National League System)  ",
                            Location = "Kent",
                            Name = "West Kent League",
                            Photo = "https://www.pngkey.com/png/full/233-2332677_ega-png.png"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The East Kent League, is a football competition based in Kent, England. The league has seven senior divisions – a Premier Division, Division One East and West, Division Two East and West and Division Three East and West. It sits below the Southern Counties East League Division One (step 6 of the National League System)",
                            Location = "Kent",
                            Name = "East Kent League",
                            Photo = "https://www.pngkey.com/png/full/233-2332677_ega-png.png"
                        });
                });

            modelBuilder.Entity("FootballLeagueFinder.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShirtNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("FootballLeagueFinder.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Manager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LeagueId = 1,
                            Manager = "Sid Bananas",
                            Name = "West Kent United",
                            Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif"
                        },
                        new
                        {
                            Id = 2,
                            LeagueId = 1,
                            Manager = "Dave Turnip",
                            Name = "Jongo Town",
                            Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif"
                        },
                        new
                        {
                            Id = 3,
                            LeagueId = 1,
                            Manager = "Jay Apple",
                            Name = "Dunkirk Athletic",
                            Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif"
                        },
                        new
                        {
                            Id = 4,
                            LeagueId = 2,
                            Manager = "Fred Grape",
                            Name = "Dels Dynamos",
                            Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif"
                        },
                        new
                        {
                            Id = 5,
                            LeagueId = 2,
                            Manager = "Chris Pommegranette",
                            Name = "Hammly Rangers",
                            Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif"
                        },
                        new
                        {
                            Id = 6,
                            LeagueId = 2,
                            Manager = "Tom Potato",
                            Name = "Keebo United",
                            Photo = "http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif"
                        });
                });

            modelBuilder.Entity("FootballLeagueFinder.Models.Player", b =>
                {
                    b.HasOne("FootballLeagueFinder.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FootballLeagueFinder.Models.Team", b =>
                {
                    b.HasOne("FootballLeagueFinder.Models.League", "League")
                        .WithMany("Teams")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");
                });

            modelBuilder.Entity("FootballLeagueFinder.Models.League", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("FootballLeagueFinder.Models.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
