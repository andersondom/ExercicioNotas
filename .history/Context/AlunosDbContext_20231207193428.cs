using AppDB.Models;
using Microsoft.EntityFrameworkCore;

public class AlunosContext : DbContext
{
    public AlunosContext(DbContextOptions<AlunosContext> options) : base(options)
    {

    }

    public DbSet<Alunos> alunos { get; set; }
}