namespace MyLearnFuture.Domain.Entities;

public class BasedTableEntity
{
    public bool IsDelete { get; set;}
    public string? CreateBy { get; set;}
    public DateTime? CreateDate { get; set;}
}