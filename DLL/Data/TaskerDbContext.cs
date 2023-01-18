using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data;

public class TaskerDbContext : DbContext
{
    public TaskerDbContext() { }

    public TaskerDbContext(DbContextOptions<TaskerDbContext> options) : base(options) { }

    public virtual DbSet<Assignment> Assignments { get; set; } = null!;
}
