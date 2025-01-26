namespace MyLearnFuture.Domain.Entities;

public class SpacedRepetitionConfigEntity: BasedTableEntity
{
    public Guid Id { get; set;}
    public int DurationHours { get; set;}
    public int DurationDays { get; set;}

    public ICollection<SpacedRepetitionConfigEntity>? SpacedRepetitionConfig_VocabulariesEntity  { get; set; }
}