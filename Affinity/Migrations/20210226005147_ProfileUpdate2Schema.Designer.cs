﻿// <auto-generated />
using System;
using Affinity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Affinity.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210226005147_ProfileUpdate2Schema")]
    partial class ProfileUpdate2Schema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Affinity.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageURL")
                        .HasColumnName("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnName("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("ImageId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Affinity.Models.InterestCategory", b =>
                {
                    b.Property<int>("InterestCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InterestCategoryId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InterestCategoryName")
                        .IsRequired()
                        .HasColumnName("InterestCategoryName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("InterestCategoryId");

                    b.ToTable("InterestCategory");

                    b.HasData(
                        new
                        {
                            InterestCategoryId = 1,
                            InterestCategoryName = "Music"
                        },
                        new
                        {
                            InterestCategoryId = 2,
                            InterestCategoryName = "Food"
                        },
                        new
                        {
                            InterestCategoryId = 3,
                            InterestCategoryName = "Gaming"
                        },
                        new
                        {
                            InterestCategoryId = 4,
                            InterestCategoryName = "Sports"
                        },
                        new
                        {
                            InterestCategoryId = 5,
                            InterestCategoryName = "Literature"
                        });
                });

            modelBuilder.Entity("Affinity.Models.InterestSubCategory", b =>
                {
                    b.Property<int>("InterestSubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InterestSubCategoryId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InterestCategoryId")
                        .HasColumnName("InterestCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("InterestSubCategoryName")
                        .IsRequired()
                        .HasColumnName("InterestSubCategoryName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("InterestSubCategoryId");

                    b.HasIndex("InterestCategoryId");

                    b.ToTable("InterestSubCategory");

                    b.HasData(
                        new
                        {
                            InterestSubCategoryId = 1,
                            InterestCategoryId = 1,
                            InterestSubCategoryName = "Rock"
                        },
                        new
                        {
                            InterestSubCategoryId = 2,
                            InterestCategoryId = 1,
                            InterestSubCategoryName = "Rap"
                        },
                        new
                        {
                            InterestSubCategoryId = 3,
                            InterestCategoryId = 1,
                            InterestSubCategoryName = "Classical"
                        },
                        new
                        {
                            InterestSubCategoryId = 4,
                            InterestCategoryId = 1,
                            InterestSubCategoryName = "Country"
                        },
                        new
                        {
                            InterestSubCategoryId = 5,
                            InterestCategoryId = 1,
                            InterestSubCategoryName = "Jazz"
                        },
                        new
                        {
                            InterestSubCategoryId = 6,
                            InterestCategoryId = 2,
                            InterestSubCategoryName = "Asian"
                        },
                        new
                        {
                            InterestSubCategoryId = 7,
                            InterestCategoryId = 2,
                            InterestSubCategoryName = "European"
                        },
                        new
                        {
                            InterestSubCategoryId = 8,
                            InterestCategoryId = 2,
                            InterestSubCategoryName = "North American"
                        },
                        new
                        {
                            InterestSubCategoryId = 9,
                            InterestCategoryId = 2,
                            InterestSubCategoryName = "South American"
                        },
                        new
                        {
                            InterestSubCategoryId = 10,
                            InterestCategoryId = 2,
                            InterestSubCategoryName = "Africa"
                        },
                        new
                        {
                            InterestSubCategoryId = 11,
                            InterestCategoryId = 3,
                            InterestSubCategoryName = "RPG"
                        },
                        new
                        {
                            InterestSubCategoryId = 12,
                            InterestCategoryId = 3,
                            InterestSubCategoryName = "Action"
                        },
                        new
                        {
                            InterestSubCategoryId = 13,
                            InterestCategoryId = 3,
                            InterestSubCategoryName = "Strategy"
                        },
                        new
                        {
                            InterestSubCategoryId = 14,
                            InterestCategoryId = 3,
                            InterestSubCategoryName = "Simulation"
                        },
                        new
                        {
                            InterestSubCategoryId = 15,
                            InterestCategoryId = 3,
                            InterestSubCategoryName = "Sandbox"
                        },
                        new
                        {
                            InterestSubCategoryId = 16,
                            InterestCategoryId = 4,
                            InterestSubCategoryName = "Basketball"
                        },
                        new
                        {
                            InterestSubCategoryId = 17,
                            InterestCategoryId = 4,
                            InterestSubCategoryName = "Hockey"
                        },
                        new
                        {
                            InterestSubCategoryId = 18,
                            InterestCategoryId = 4,
                            InterestSubCategoryName = "Soccer"
                        },
                        new
                        {
                            InterestSubCategoryId = 19,
                            InterestCategoryId = 4,
                            InterestSubCategoryName = "Football"
                        },
                        new
                        {
                            InterestSubCategoryId = 20,
                            InterestCategoryId = 4,
                            InterestSubCategoryName = "VolleyBall"
                        },
                        new
                        {
                            InterestSubCategoryId = 21,
                            InterestCategoryId = 5,
                            InterestSubCategoryName = "Sci Fi"
                        },
                        new
                        {
                            InterestSubCategoryId = 22,
                            InterestCategoryId = 5,
                            InterestSubCategoryName = "Fantasy"
                        },
                        new
                        {
                            InterestSubCategoryId = 23,
                            InterestCategoryId = 5,
                            InterestSubCategoryName = "Non-Fiction"
                        },
                        new
                        {
                            InterestSubCategoryId = 24,
                            InterestCategoryId = 5,
                            InterestSubCategoryName = "Fiction"
                        },
                        new
                        {
                            InterestSubCategoryId = 25,
                            InterestCategoryId = 5,
                            InterestSubCategoryName = "Historical"
                        });
                });

            modelBuilder.Entity("Affinity.Models.Interests", b =>
                {
                    b.Property<int>("InterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InterestId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InterestCategoryId")
                        .HasColumnName("InterestCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("InterestSubCategoryId")
                        .HasColumnName("InterestSubCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("InterestId");

                    b.HasIndex("InterestCategoryId");

                    b.HasIndex("InterestSubCategoryId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("Affinity.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("Description")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Discord")
                        .IsRequired()
                        .HasColumnName("Discord")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Instagram")
                        .IsRequired()
                        .HasColumnName("Instagram")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnName("Location")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnName("Occupation")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("ProfileName")
                        .IsRequired()
                        .HasColumnName("ProfileName")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProfileId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("Affinity.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "fde36ca1-d495-49ad-ab8e-6d324f007950",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "b20345bf-2fec-4c11-9341-3426c5c25a0f",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("Affinity.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AccountNum")
                        .IsRequired()
                        .HasColumnName("AccountNum")
                        .HasColumnType("varchar(36)")
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnName("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnName("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128)
                        .IsUnicode(false);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            AccountNum = "6a59fe80-f215-4730-9682-75401b28ca03",
                            BirthDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "50d50fb1-8037-451c-95fb-91ca0cbf8ec8",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            Gender = "Other",
                            LockoutEnabled = false,
                            Name = "Admin",
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEH7dg+WgzdmnmJH/k/mqhk2DOvIynytkw3Z9SbHSPKhWhnI9+phFkolREuwE7E4m7g==",
                            PhoneNumber = "555-555-5555",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            AccountNum = "969bd8fe-daee-4830-8adc-604ec727affa",
                            BirthDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "fe21fe5e-f675-405d-ad6c-728475965524",
                            Email = "user@user.com",
                            EmailConfirmed = true,
                            Gender = "Other",
                            LockoutEnabled = false,
                            Name = "User",
                            NormalizedEmail = "USER@USER.COM",
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEP0EyAnacPcpx2suCFO71RbcyaNnr70Tx9Uk7VR60M/umkF8RGAo9tnamGcDr+4bsw==",
                            PhoneNumber = "555-555-5555",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "ProviderKey", "LoginProvider");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Affinity.Models.Image", b =>
                {
                    b.HasOne("Affinity.Models.Profile", "Profile")
                        .WithMany("Images")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Affinity.Models.InterestSubCategory", b =>
                {
                    b.HasOne("Affinity.Models.InterestCategory", "InterestCategory")
                        .WithMany("InterestSubCategories")
                        .HasForeignKey("InterestCategoryId")
                        .HasConstraintName("FK_Sub_InterestCategory")
                        .IsRequired();
                });

            modelBuilder.Entity("Affinity.Models.Interests", b =>
                {
                    b.HasOne("Affinity.Models.InterestCategory", "InterestCategory")
                        .WithMany()
                        .HasForeignKey("InterestCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Affinity.Models.InterestSubCategory", "InterestSubCategory")
                        .WithMany("Interests")
                        .HasForeignKey("InterestSubCategoryId")
                        .HasConstraintName("FK_Interest_SubCategory")
                        .IsRequired();

                    b.HasOne("Affinity.Models.Profile", "Profile")
                        .WithMany("Interests")
                        .HasForeignKey("ProfileId")
                        .HasConstraintName("FK_Profile_Interests")
                        .IsRequired();
                });

            modelBuilder.Entity("Affinity.Models.Profile", b =>
                {
                    b.HasOne("Affinity.Models.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Affinity.Models.Profile", "UserId")
                        .HasConstraintName("FK_Profile_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Affinity.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Affinity.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Affinity.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Affinity.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Affinity.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Affinity.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
