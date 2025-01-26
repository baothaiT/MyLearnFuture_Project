using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyLearnFuture.Domain.Entities;

namespace MyLearnFuture.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
    }

    public DbSet<ImagesEntity> ImagesTable { get; set; }
    public DbSet<TopicsEntity> TopicsTable { get; set; }
    public DbSet<SpacedRepetitionConfigEntity> SpacedRepetitionConfigTable { get; set; }
    public DbSet<VocabulariesEntity> VocabulariesTable { get; set; }
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

        #region VocabulariesEntity
        modelBuilder.Entity<VocabulariesEntity>().HasKey(x => x.Id);

        modelBuilder.Entity<VocabulariesEntity>()
        .HasOne(a => a.SpacedRepetition)
        .WithMany(at => at.SpacedRepetitionConfigEntity_VocabulariesEntity)
        .HasForeignKey(a => a.SpacedRepetition_Id);

        modelBuilder.Entity<VocabulariesEntity>()
        .HasOne(a => a.Image)
        .WithMany(at => at.ImagesEntity_VocabulariesEntity)
        .HasForeignKey(a => a.Image_Id);

        modelBuilder.Entity<VocabulariesEntity>()
        .HasOne(a => a.Topic)
        .WithMany(at => at.TopicsEntity_VocabulariesEntity)
        .HasForeignKey(a => a.Topic_Id);

        #endregion

        modelBuilder = DataSeeding(modelBuilder);
    }

    private ModelBuilder DataSeeding(ModelBuilder modelBuilder)
    {
        #region ImagesEntity
        Guid imageId1 = Guid.Parse("170870F1-DEFF-44AD-A64E-6D82BACA96A8");
        Guid imageId2 = Guid.Parse("DF26B731-E9EB-455C-BC35-B2086F22B87D");
        Guid imageId3 = Guid.Parse("6E79F4E1-BEE7-427E-9A6A-00F7A4EB8BFB");

        ImagesEntity imagesEntity1 = new ImagesEntity()
        {
            Id = imageId1,
            Name = "Name",
            Url = "URL"
        };

        ImagesEntity imagesEntity2 = new ImagesEntity()
        {
            Id = imageId2,
            Name = "Name",
            Url = "URL"
        };

        ImagesEntity imagesEntity3 = new ImagesEntity()
        {
            Id = imageId3,
            Name = "Name",
            Url = "URL",
            CreateDate = DateTime.Parse("2025-01-27")
        };

        modelBuilder.Entity<ImagesEntity>().HasData(imagesEntity1, imagesEntity2, imagesEntity3);
        #endregion

        #region TopicsEntity

        Guid topicId1 = Guid.Parse("D9ECDD00-F934-42BC-9D9F-A286CFEC8DB1");
        Guid topicId2 = Guid.Parse("699A0A8C-63D2-4A3C-84FC-5179C19102E3");

        TopicsEntity topicsEntity1 = new TopicsEntity()
        {
            Id = topicId1,
            Name = "Topic1",
            CreateDate = DateTime.Parse("2025-01-27")
        };

        TopicsEntity topicsEntity2 = new TopicsEntity()
        {
            Id = topicId2,
            Name = "Topic2",
            CreateDate = DateTime.Parse("2025-01-27")
        };

        modelBuilder.Entity<TopicsEntity>().HasData(topicsEntity1, topicsEntity2);

        #endregion

        #region SpacedRepetitionConfigEntity
        Guid spacedRepetitionConfigId1 = Guid.Parse("0F8F9715-4B2D-4825-A7C8-F455F829B50E");
        Guid spacedRepetitionConfigId2 = Guid.Parse("2EC77B9F-3A76-4954-98FB-71639F3EA63E");

        SpacedRepetitionConfigEntity spacedRepetitionConfigEntity1 = new SpacedRepetitionConfigEntity()
        {
            Id = spacedRepetitionConfigId1,
            DurationHours = 1,
            DurationDays = 0,
            CreateDate = DateTime.Parse("2025-01-27")
        };

        SpacedRepetitionConfigEntity spacedRepetitionConfigEntity2 = new SpacedRepetitionConfigEntity()
        {
            Id = spacedRepetitionConfigId2,
            DurationHours = 2,
            DurationDays = 0,
            CreateDate = DateTime.Parse("2025-01-27")
        };

        modelBuilder.Entity<SpacedRepetitionConfigEntity>().HasData(spacedRepetitionConfigEntity1, spacedRepetitionConfigEntity2);
        #endregion

        #region VocabulariesEntity
        Guid vocabulariesEntityId1 = Guid.Parse("DC5C06D2-3359-4807-B0D4-AAD40EE7C5AF");
        Guid vocabulariesEntityId2 = Guid.Parse("2D7EC305-76B2-4938-A43A-0A777645B910");

        VocabulariesEntity vocabulariesEntity1 = new VocabulariesEntity()
        {
            Id = vocabulariesEntityId1,
            Key = "Key1",
            Value = "Value1",
            SpacedRepetition_LastLearn = DateTime.Parse("2025-01-27"),
            Transcription = "Transcription",
            SpacedRepetition_Id = spacedRepetitionConfigId1,
            Image_Id = imageId1,
            Topic_Id = topicId1,
            CreateDate = DateTime.Parse("2025-01-27")
        };

        VocabulariesEntity vocabulariesEntity2 = new VocabulariesEntity()
        {
            Id = vocabulariesEntityId2,
            Key = "Key1",
            Value = "Value1",
            SpacedRepetition_LastLearn = DateTime.Parse("2025-01-27"),
            Transcription = "Transcription",
            SpacedRepetition_Id = spacedRepetitionConfigId2,
            Image_Id = imageId2,
            Topic_Id = topicId2,
            CreateDate = DateTime.Parse("2025-01-27")
        };

        modelBuilder.Entity<VocabulariesEntity>().HasData(vocabulariesEntity1, vocabulariesEntity2);

        #endregion

        return modelBuilder;
    }
}
