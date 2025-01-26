namespace MyLearnFuture.Domain.Entities;

public class TopicsEntity: BasedTableEntity
{
    public Guid Id { get; set;}
    public string? Name { get; set;}

    public ICollection<VocabulariesEntity>? TopicsEntity_VocabulariesEntity { get; set; }
}