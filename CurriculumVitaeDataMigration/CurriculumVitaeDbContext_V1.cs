﻿using CurriculumVitae.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CurriculumVitae.Data;

public class CurriculumVitaeDbContext_V1 : DbContext
{
    public CurriculumVitaeDbContext_V1(DbContextOptions<CurriculumVitaeDbContext_V1> options) : base(options) { }

    public DbSet<ComputerVaardigheid> computerVaardigheiden { get; set; } = null!;
    public DbSet<Profiel> Profielen {  get; set; } = null!; 
    public DbSet<TaalModel> Talen { get; set; } = null!;
    public DbSet<WerkErvaring> WerkErvaringen { get; set; } = null!;
    public DbSet<PersoonlijkeVaardigheid> PersoonlijkeVaardigheden { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); 
    }
}
