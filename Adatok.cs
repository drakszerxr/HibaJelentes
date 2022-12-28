using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HibaJelentes;

public partial class Adatok : DbContext
{
    public Adatok()
    {
    }

    public Adatok(DbContextOptions<Adatok> options)
        : base(options)
    {
    }

    public virtual DbSet<Table> Tables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Peti\\Documents\\aa.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Table__3214EC079DED315E");

            entity.ToTable("Table");

            entity.Property(e => e.Datum).HasColumnType("date");
            entity.Property(e => e.Irszam).HasColumnType("text");
            entity.Property(e => e.Utca).HasColumnType("text");
            entity.Property(e => e.Varos).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
