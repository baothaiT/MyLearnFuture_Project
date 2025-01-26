using Microsoft.EntityFrameworkCore;
using MyLearnFuture.Domain.Entities;

namespace MyLearnFuture.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
    }

    public DbSet<ImagesEntity> ImagesTable { get; set; }
    public DbSet<TopicsEntity> TopicsTable { get; set; }
    public DbSet<VocabulariesEntity> VocabulariesTable { get; set; }
    public DbSet<SpacedRepetitionConfigEntity> SpacedRepetitionConfigTable { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        #region ImagesEntity
        modelBuilder.Entity<ImagesEntity>().HasKey(x => x.Id);
        #endregion

        #region TopicsEntity
        modelBuilder.Entity<TopicsEntity>().HasKey(x => x.Id);
        #endregion

        #region SpacedRepetitionConfigEntity
        modelBuilder.Entity<SpacedRepetitionConfigEntity>().HasKey(x => x.Id);
        #endregion

        // VocabulariesEntity
        #region VocabulariesEntity
        modelBuilder.Entity<VocabulariesEntity>().HasKey(x => x.Id);

        //modelBuilder.Entity<VocabulariesEntity>()
        //    .HasOne(a => a.SpacedRepetition)
        //    .WithMany(at => at.SpacedRepetitionConfig_VocabulariesEntity)
        //    .HasForeignKey(a => a.SpacedRepetition_Id);

        #endregion
    }
}
