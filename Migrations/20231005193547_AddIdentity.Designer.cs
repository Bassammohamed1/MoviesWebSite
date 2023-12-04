﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Models;

#nullable disable

namespace Movies.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231005193547_AddIdentity")]
    partial class AddIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProviderKey");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Movies.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Src")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Cillian Murphy is an Irish actor. He made his professional debut in Enda Walsh's 1996 play Disco Pigs, a role he later reprised in the 2001 screen adaptation.",
                            Name = "Cillian Murphy",
                            Src = "https://encrypted-tbn1.gstatic.com/licensed-image?q=tbn:ANd9GcTzsv2mdNgXUg6UHxeW-C9awUeI2073Chv_rPRJca3NcOgo0UKqGAxOr0O39ILt708Q2ve9E1MxrNMPaJA"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "Robert John Downey Jr. is an American actor. His career has been characterized by critical success in his youth, followed by a period of substance abuse and legal troubles, and a surge in popular and commercial success later in his career.",
                            Name = "Robert Downey Jr.",
                            Src = "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcTof5XGzxuO6J2TdrCnII3RFqhj3jj_X4Qzwe52Ebo7veL-6y4ZPSzAJIIsKZVv662aOS8w4QBrmD3p6Bc"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "Matthew David McConaughey is an American actor. He had his breakout role with a supporting performance in the coming-of-age comedy Dazed and Confused. After a number of supporting roles, his first success as a leading man came in the legal drama A Time to Kill.",
                            Name = "Matthew McConaughey",
                            Src = "https://encrypted-tbn1.gstatic.com/licensed-image?q=tbn:ANd9GcS03vLTavK8Bw69E-firOBBRMbM4nt2FThIqBQFRcwDVyh48hpa09uYVCcwhGNDxtSR-nMc_19O2RAhr9s"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "Jessica Chastain is an American actress of film, television, and stage. As a final-year student at the Juilliard School, she was signed on for a talent holding deal by the television producer John Wells.",
                            Name = "Jessica Chastain",
                            Src = "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcRwFmx29NKSIJl6qaTO1DT7sJjoOOBQi3W9WEdjV88H-3ceQ12rhEIomrUl52sA118ZWoIFFDXruKpKgrM"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "hristian Charles Philip Bale is an English actor. Known for his versatility and physical transformations for his roles, he has been a leading man in films of several genres. He has received various accolades, including an Academy Award and two Golden Globe Awards. ",
                            Name = "Christian Bale",
                            Src = "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcTgwC2GrtpVJp6H4hd49UtRWqHW1yCWW7O6a2lOwTp3VLLwy9G_YOnLpJb_Tp1UHGUviCy1_36EmM-vFiw"
                        },
                        new
                        {
                            Id = 6,
                            Bio = "Heath Andrew Ledger was an Australian actor. After playing roles in several Australian television and film productions during the 1990s, Ledger moved to the United States in 1998 to develop his film career further.",
                            Name = "Heath Ledger",
                            Src = "https://encrypted-tbn3.gstatic.com/licensed-image?q=tbn:ANd9GcR3VUtiCinec9LWn0cGBfgQEnMGGLEAWC6sZtYbMO7HMjYRPmANwQ6NFNLzG8xQVMZftTUHSIqasTHsJ0k"
                        });
                });

            modelBuilder.Entity("Movies.Models.ActorMovie", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("ActorMovies");

                    b.HasData(
                        new
                        {
                            MovieId = 3,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 3,
                            ActorId = 2
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 3
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 4
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 5
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 6
                        });
                });

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MoiveCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<string>("Src")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.",
                            MoiveCategory = 1,
                            Name = "Interstellar",
                            ProducerId = 1,
                            Src = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRf61mker2o4KH3CbVE7Zw5B1-VogMH8LfZHEaq3UdCMLxARZAB",
                            price = 150.0
                        },
                        new
                        {
                            Id = 2,
                            Bio = "After Gordon, Dent and Batman begin an assault on Gotham's organised crime, the mobs hire the Joker, a psychopathic criminal mastermind who offers to kill Batman and bring the city to its knees.",
                            MoiveCategory = 0,
                            Name = "The Dark Knight",
                            ProducerId = 1,
                            Src = "https://contentserver.com.au/assets/598411_p173378_p_v8_au.jpg",
                            price = 100.0
                        },
                        new
                        {
                            Id = 3,
                            Bio = "During World War II, Lt. Gen. Leslie Groves Jr. appoints physicist J. Robert Oppenheimer to work on the top-secret Manhattan Project. Oppenheimer and a team of scientists spend years developing and designing the atomic bomb. Their work comes to fruition on July 16, 1945, as they witness the world's first nuclear explosion, forever changing the course of history.",
                            MoiveCategory = 1,
                            Name = "Oppenheimer",
                            ProducerId = 1,
                            Src = "https://pbs.twimg.com/media/FvUVt3hXgAAxP1H?format=jpg&name=900x900",
                            price = 200.0
                        });
                });

            modelBuilder.Entity("Movies.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Src")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Christopher Edward Nolan CBE is a British and American filmmaker. Known for his Hollywood blockbusters with complex storytelling, Nolan is considered a leading filmmaker of the 21st century. His films have grossed $5 billion worldwide.",
                            Name = "Christopher Nolan",
                            Src = "https://encrypted-tbn1.gstatic.com/licensed-image?q=tbn:ANd9GcTfWsTYHBYRh-5_YJxaKqZaqcxNp0GCoL-CQcdtqoX0ROYto2I8MwHcQoEypJTUlnDzUMsvCeFnUHZ1ID0"
                        });
                });

            modelBuilder.Entity("Movies.Models.ActorMovie", b =>
                {
                    b.HasOne("Movies.Models.Actor", "Actor")
                        .WithMany("ActorMovies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movies.Models.Movie", "Movie")
                        .WithMany("ActorMovies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.HasOne("Movies.Models.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("Movies.Models.Actor", b =>
                {
                    b.Navigation("ActorMovies");
                });

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.Navigation("ActorMovies");
                });

            modelBuilder.Entity("Movies.Models.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
