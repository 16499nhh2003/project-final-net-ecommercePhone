﻿// <auto-generated />
using System;
using FinalEcormer2023.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalEcormer2023.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalEcormer2023.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Iphone"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ipad"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mac"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Watch"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Phụ kiện"
                        });
                });

            modelBuilder.Entity("FinalEcormer2023.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FinalEcormer2023.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("FinalEcormer2023.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Color = "red",
                            Description = "Ra mắt vào năm 2023",
                            Name = "iphone 15 Pro Max 1TB red",
                            Price = 1000000m,
                            Url = "https://cdn.tgdd.vn/Products/Images/42/305659/iphone-15-pro-max-white-thumbnew-600x600.jpg"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Color = "white",
                            Description = "Ra mắt vào năm 2023",
                            Name = "iphone 15 Pro Max 1TB white",
                            Price = 3231000m,
                            Url = "https://cdn.tgdd.vn/Products/Images/42/305659/iphone-15-pro-max-white-thumbnew-600x600.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Color = "pink",
                            Description = "Ra mắt vào năm 2023",
                            Name = "iphone 15 Pro Max 1TB pink",
                            Price = 2313000m,
                            Url = "https://shopdunk.com/images/thumbs/0022255_iphone-15-128gb_240.png"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Color = "black",
                            Description = "Ra mắt vào năm 2023",
                            Name = "Ipad Pro Max 1TB black",
                            Price = 23838000m,
                            Url = "https://shopdunk.com/images/thumbs/0022263_iphone-15-pro-128gb_240.png"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Color = "green",
                            Description = "Ra mắt vào năm 2023",
                            Name = "Ipad Pro Max 1TB green",
                            Price = 2133000m,
                            Url = "https://shopdunk.com/images/thumbs/0000594_ipad-air-4_240.png"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Color = "black",
                            Description = "Ra mắt vào năm 2023",
                            Name = "ipad-gen-9-102-inch-wifi-64gb",
                            Price = 5222000m,
                            Url = "https://shopdunk.com/images/thumbs/0006205_ipad-gen-9-102-inch-wifi-64gb_240.png"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Color = "pink",
                            Description = "Ra mắt vào năm 2023",
                            Name = "macbook-air-m1-2020-8gb-ram-256gb ",
                            Price = 2994000m,
                            Url = "https://shopdunk.com/images/thumbs/0000723_macbook-air-m1-2020-8gb-ram-256gb-ssd_240.png"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Color = "silver",
                            Description = "Ra mắt vào năm 2023",
                            Name = "macbook-air-m2-2022-8gb-ram-256gbr",
                            Price = 20000000m,
                            Url = "https://shopdunk.com/images/thumbs/0008502_macbook-air-m2-2022-8gb-ram-256gb-ssd_240.png"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Color = "black",
                            Description = "Ra mắt vào năm 2023",
                            Name = "Macbook pro 13 black",
                            Price = 10000000m,
                            Url = "https://shopdunk.com/images/thumbs/0008682_macbook-pro-13-inch-m2-10-core-8gb-ram-256gb-ssd_240.png"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 4,
                            Color = "black",
                            Description = "Ra mắt vào năm 2023",
                            Name = "Macbook pro 14 m2 black",
                            Price = 12341000m,
                            Url = "https://shopdunk.com/images/thumbs/0011267_macbook-pro-14-inch-m2-pro-16-core-16gb-512gb_240.jpeg"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 4,
                            Color = "grey",
                            Description = "Ra mắt vào năm 2023",
                            Name = "Watch se",
                            Price = 20202000m,
                            Url = "https://shopdunk.com/images/thumbs/0022272_apple-watch-se-nhom-2022-gps_240.jpeg"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            Color = "grey",
                            Description = "Ra mắt vào năm 2023",
                            Name = "Watch se",
                            Price = 1999000m,
                            Url = "https://shopdunk.com/images/thumbs/0022275_apple-watch-se-2023-gps-sport-band-size-sm_240.jpeg"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 4,
                            Color = "grey",
                            Description = "Ra mắt vào năm 2023",
                            Name = "apple-watch-se-2023-gps-cellular",
                            Price = 2000000m,
                            Url = "https://shopdunk.com/images/thumbs/0022328_apple-watch-se-2023-gps-cellular-sport-band-size-sm_240.png"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 5,
                            Color = "grey",
                            Description = "Ra mắt vào năm 2023",
                            Name = "sac-20w-usb-c-power-adapter",
                            Price = 2000000m,
                            Url = "https://shopdunk.com/images/thumbs/0001395_sac-20w-usb-c-power-adapter_240.png"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 5,
                            Color = "grey",
                            Description = "Ra mắt vào năm 2023",
                            Name = "airpods-pro-2",
                            Price = 2000000m,
                            Url = "https://shopdunk.com/images/thumbs/0000211_airpods-pro-2_240.png"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 5,
                            Color = "grey",
                            Description = "Ra mắt vào năm 2023",
                            Name = "tai-nghe-apple-airpods-3",
                            Price = 24197000m,
                            Url = "https://shopdunk.com/images/thumbs/0006057_tai-nghe-apple-airpods-3-sac-co-day-lightning_240.jpeg"
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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "2aaf8c82-a7d7-4b3d-b6c2-3d88ec99f201",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "2123a1de-6681-4e9a-88d0-9b3277a2a9e2",
                            Name = "User",
                            NormalizedName = "USER"
                        });
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
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = "9b6b23c6-5d72-4d45-9ac6-2c62dbf7d7d5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "83117769-3e20-432e-8a38-ec468feec4a3",
                            Email = "caonguyenbinh12@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CAONGUYENBINH12@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEI3cwVnGz1PUvhSH1fr+pDvMzQ2B95oZcHIhErlJH1hFflaqFW81wK6ToaQY0V7FZw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
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
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "9b6b23c6-5d72-4d45-9ac6-2c62dbf7d7d5",
                            RoleId = "1"
                        });
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("FinalEcormer2023.Models.Order", b =>
                {
                    b.HasOne("AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("FinalEcormer2023.Models.OrderDetail", b =>
                {
                    b.HasOne("FinalEcormer2023.Models.Order", "Order")
                        .WithMany("orderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalEcormer2023.Models.Product", "Product")
                        .WithMany("orderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FinalEcormer2023.Models.Product", b =>
                {
                    b.HasOne("FinalEcormer2023.Models.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalEcormer2023.Models.Category", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("FinalEcormer2023.Models.Order", b =>
                {
                    b.Navigation("orderDetails");
                });

            modelBuilder.Entity("FinalEcormer2023.Models.Product", b =>
                {
                    b.Navigation("orderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
