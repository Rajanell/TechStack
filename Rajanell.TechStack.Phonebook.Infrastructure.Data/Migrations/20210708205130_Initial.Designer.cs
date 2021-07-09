﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rajanell.TechStack.Phonebook.Infrastructure.Data;

namespace Rajanell.TechStack.Phonebook.Infrastructure.Data.Migrations
{
    [DbContext(typeof(PhoneBookDBContext))]
    [Migration("20210708205130_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rajanell.TechStack.Phonebook.Core.Model.Entry", b =>
                {
                    b.Property<Guid>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PhoneBookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntryId");

                    b.HasIndex("PhoneBookId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("Rajanell.TechStack.Phonebook.Core.Model.PhoneBook", b =>
                {
                    b.Property<Guid>("PhoneBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneBookId");

                    b.ToTable("PhoneBooks");
                });

            modelBuilder.Entity("Rajanell.TechStack.Phonebook.Core.Model.Entry", b =>
                {
                    b.HasOne("Rajanell.TechStack.Phonebook.Core.Model.PhoneBook", "PhoneBook")
                        .WithMany("Entries")
                        .HasForeignKey("PhoneBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
