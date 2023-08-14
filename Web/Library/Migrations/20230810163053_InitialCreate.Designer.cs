﻿// <auto-generated />
using System;
using Library;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20230810163053_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DesignLibraryManagementSystem.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("DesignLibraryManagementSystem.Models.LibraryMember", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MemberID");

                    b.ToTable("LibraryMember");
                });

            modelBuilder.Entity("DesignLibraryManagementSystem.Models.LibraryTransaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionID"));

                    b.Property<int>("BookIDId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("DateTime");

                    b.Property<int>("MemberID1")
                        .HasColumnType("int");

                    b.HasKey("TransactionID");

                    b.HasIndex("BookIDId");

                    b.HasIndex("MemberID1");

                    b.ToTable("LibraryTransaction");
                });

            modelBuilder.Entity("DesignLibraryManagementSystem.Models.LibraryTransaction", b =>
                {
                    b.HasOne("DesignLibraryManagementSystem.Models.Book", "BookID")
                        .WithMany("LibraryTransaction")
                        .HasForeignKey("BookIDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesignLibraryManagementSystem.Models.LibraryMember", "MemberID")
                        .WithMany()
                        .HasForeignKey("MemberID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookID");

                    b.Navigation("MemberID");
                });

            modelBuilder.Entity("DesignLibraryManagementSystem.Models.Book", b =>
                {
                    b.Navigation("LibraryTransaction");
                });
#pragma warning restore 612, 618
        }
    }
}
