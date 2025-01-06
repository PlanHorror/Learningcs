using System;
using Microsoft.EntityFrameworkCore;

namespace Learningcs.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

}
