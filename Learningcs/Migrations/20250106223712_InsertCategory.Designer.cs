﻿// <auto-generated />
using Learningcs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Learningcs.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250106223712_InsertCategory")]
    partial class InsertCategory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Learningcs.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Web Development",
                            DisplayOrder = 1,
                            Name = "Web Development"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Programming Languages",
                            DisplayOrder = 2,
                            Name = "Programming Languages"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Databases",
                            DisplayOrder = 3,
                            Name = "Databases"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "DevOps",
                            DisplayOrder = 4,
                            Name = "DevOps"
                        },
                        new
                        {
                            CategoryId = 5,
                            Description = "Software Testing",
                            DisplayOrder = 5,
                            Name = "Software Testing"
                        },
                        new
                        {
                            CategoryId = 6,
                            Description = "Software Engineering",
                            DisplayOrder = 6,
                            Name = "Software Engineering"
                        },
                        new
                        {
                            CategoryId = 7,
                            Description = "Mobile Development",
                            DisplayOrder = 7,
                            Name = "Mobile Development"
                        },
                        new
                        {
                            CategoryId = 8,
                            Description = "Project Management",
                            DisplayOrder = 8,
                            Name = "Project Management"
                        },
                        new
                        {
                            CategoryId = 9,
                            Description = "Business",
                            DisplayOrder = 9,
                            Name = "Business"
                        },
                        new
                        {
                            CategoryId = 10,
                            Description = "Personal Development",
                            DisplayOrder = 10,
                            Name = "Personal Development"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
