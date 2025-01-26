namespace MyLearnFuture.Domain.Entities;

public class ImagesEntity: BasedTableEntity
{
    public Guid Id { get; set;}
    public string Name { get; set;}
    public string? Url { get; set;}

    public ICollection<VocabulariesEntity>? ImagesEntity_VocabulariesEntity { get; set;}
}
