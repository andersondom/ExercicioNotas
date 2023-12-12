using AppDB.Models;
using Microsoft.EntityFrameworkCore;

public class AlunosDbContext : DbContext
{
    public AlunosDbContext(DbContextOptions<AlunosDbContext> options) : base(options)
    {

    }

    public DbSet<Alunos> alunos { get; set; }
}