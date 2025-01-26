namespace MyLearnFuture.Domain.Entities;

public class SpacedRepetitionConfigEntity //: BasedTableEntity
{
    public Guid Id { get; set;}
    public int DurationHours { get; set;}
    public int DurationDays { get; set;}

    public bool IsDelete { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? CreateDate { get; set; }

    public ICollection<VocabulariesEntity>? SpacedRepetitionConfigEntity_VocabulariesEntity { get; set; }
}