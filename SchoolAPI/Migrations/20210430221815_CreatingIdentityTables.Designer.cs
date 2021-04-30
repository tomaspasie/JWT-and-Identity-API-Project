﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SchoolAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210430221815_CreatingIdentityTables")]
    partial class CreatingIdentityTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Assignment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Assignments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991873"),
                            Name = "Assignment 1",
                            Score = 78
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Name = "Assignment 2",
                            Score = 93
                        },
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991874"),
                            Name = "Assignment 3",
                            Score = 64
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce5"),
                            Name = "Assignment 4",
                            Score = 88
                        });
                });

            modelBuilder.Entity("Entities.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<Guid?>("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("SectionId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"),
                            Name = "Advanced Web Applications"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce1"),
                            Name = "Web Mining"
                        });
                });

            modelBuilder.Entity("Entities.Models.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            City = "Bloomfield",
                            Country = "USA",
                            OrgName = "xyz org"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            City = "Lusaka",
                            Country = "ZM",
                            OrgName = "lmnop org"
                        });
                });

            modelBuilder.Entity("Entities.Models.Section", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Sections");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991872"),
                            Name = "Section 1"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce2"),
                            Name = "Section 2"
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnName("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("OrganizationId");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "57201551-17ad-43b2-80d9-80fed4068bbc",
                            AccessFailedCount = 0,
                            Age = 0,
                            ConcurrencyStamp = "bd3537a5-ea88-4584-a415-602fcae637b5",
                            EmailConfirmed = false,
                            Guid = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            LockoutEnabled = false,
                            Name = "kwilliams",
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "410ef9e2-073b-4711-93be-c67ac225a047",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "8fca41e8-fef7-42d6-b1be-aeff90042194",
                            AccessFailedCount = 0,
                            Age = 0,
                            ConcurrencyStamp = "c754a277-877a-41fe-b362-7beb8cd55f7d",
                            EmailConfirmed = false,
                            Guid = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            LockoutEnabled = false,
                            Name = "ka393939",
                            OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2bb99c09-1b63-42be-aa84-8efe3c46fa3f",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "4bbbbfd2-5f0c-4120-a18b-64bd9bad3cde",
                            AccessFailedCount = 0,
                            Age = 0,
                            ConcurrencyStamp = "16872906-c1a2-4503-ae67-3d9644c8774c",
                            EmailConfirmed = false,
                            Guid = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            LockoutEnabled = false,
                            Name = "kaw3939",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "65a445a5-8522-442e-a345-68cc81df129f",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "3864366d-ede1-4884-8b3b-cd18812a0226",
                            AccessFailedCount = 0,
                            Age = 21,
                            ConcurrencyStamp = "16461521-0131-46e9-ace6-76117e7aaeec",
                            EmailConfirmed = false,
                            Guid = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"),
                            LockoutEnabled = false,
                            Name = "Tomas",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "00544b6e-843f-4b05-9ae5-0ef344ad6522",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "ca4354c0-ea77-4088-9148-7e1e5781b083",
                            AccessFailedCount = 0,
                            Age = 25,
                            ConcurrencyStamp = "7d24533d-ac4d-4fdb-a897-5c7a28024b66",
                            EmailConfirmed = false,
                            Guid = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                            LockoutEnabled = false,
                            Name = "Natalie",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "93fec8a8-d2b3-4d19-bc2c-d4313f5aa4dc",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "0d803e8e-a6f4-44b1-b3b6-e9153d8e72f7",
                            AccessFailedCount = 0,
                            Age = 31,
                            ConcurrencyStamp = "71246a36-ba9d-4818-9906-612a5c808968",
                            EmailConfirmed = false,
                            Guid = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479814"),
                            LockoutEnabled = false,
                            Name = "Ethan",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "80d48252-9ffa-4c47-84aa-d7ae47a5ae9e",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "dae8007b-a041-47ab-860c-3f8fb9e01e81",
                            AccessFailedCount = 0,
                            Age = 28,
                            ConcurrencyStamp = "65d3c001-c808-41a1-acc4-424d1b940223",
                            EmailConfirmed = false,
                            Guid = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479815"),
                            LockoutEnabled = false,
                            Name = "Dan",
                            OrganizationId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "11d2b984-b362-4a51-b0a3-69eb7835a91d",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "ef361fcb-b15c-43b1-97c7-73ea9979a4b1",
                            ConcurrencyStamp = "d8707d7f-c31b-4427-b79e-a98d12684738",
                            Name = "Authenticated",
                            NormalizedName = "AUTHENTICATED"
                        },
                        new
                        {
                            Id = "4860a6b8-9b6d-4de8-82fe-282e770329e0",
                            ConcurrencyStamp = "7946a3a0-8b91-4bd0-bd53-3d6c4dad8b79",
                            Name = "Staff",
                            NormalizedName = "STAFF"
                        },
                        new
                        {
                            Id = "e1a40b99-c337-4800-9644-5afb90a47104",
                            ConcurrencyStamp = "81d9c0a5-b53f-41d5-93ea-e5b5193bb00f",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Entities.Models.Course", b =>
                {
                    b.HasOne("Entities.Models.Assignment", null)
                        .WithMany("Courses")
                        .HasForeignKey("AssignmentId");

                    b.HasOne("Entities.Models.Section", null)
                        .WithMany("Courses")
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.HasOne("Entities.Models.Course", null)
                        .WithMany("Users")
                        .HasForeignKey("CourseId");

                    b.HasOne("Entities.Models.Organization", "Organization")
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
