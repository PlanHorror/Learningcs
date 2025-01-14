using System;
using Learningcs.Models;
using Microsoft.EntityFrameworkCore;

namespace Learningcs.Data;
// Migration command: dotnet ef migrations add AddCategoryToDb
// Update database command: dotnet ef database update
// Install entity framework: dotnet tool install --global dotnet-ef
// Check database connection: dotnet ef dbcontext info
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    // Create new table Categories; { get; set; } is required to create a table and perform CRUD operations
    public DbSet<Learningcs.Models.Category> Categories { get; set; }
    // Seed data to Categories table
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = 1,
                Name = "Web Development",
                Description = "Web Development",
                DisplayOrder = 1
            },
            new Category
            {
                CategoryId = 2,
                Name = "Programming Languages",
                Description = "Programming Languages",
                DisplayOrder = 2
            },
            new Category
            {
                CategoryId = 3,
                Name = "Databases",
                Description = "Databases",
                DisplayOrder = 3
            },
            new Category
            {
                CategoryId = 4,
                Name = "DevOps",
                Description = "DevOps",
                DisplayOrder = 4
            },
            new Category
            {
                CategoryId = 5,
                Name = "Software Testing",
                Description = "Software Testing",
                DisplayOrder = 5
            },
            new Category
            {
                CategoryId = 6,
                Name = "Software Engineering",
                Description = "Software Engineering",
                DisplayOrder = 6
            },
            new Category
            {
                CategoryId = 7,
                Name = "Mobile Development",
                Description = "Mobile Development",
                DisplayOrder = 7
            },
            new Category
            {
                CategoryId = 8,
                Name = "Project Management",
                Description = "Project Management",
                DisplayOrder = 8
            },
            new Category
            {
                CategoryId = 9,
                Name = "Business",
                Description = "Business",
                DisplayOrder = 9
            },
            new Category
            {
                CategoryId = 10,
                Name = "Personal Development",
                Description = "Personal Development",
                DisplayOrder = 10
            }
        );
    }
}
