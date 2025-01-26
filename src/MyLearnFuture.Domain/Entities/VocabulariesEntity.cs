namespace MyLearnFuture.Domain.Entities;

public class VocabulariesEntity: BasedTableEntity
{
    public Guid Id { get; set;}
    public string Key { get; set;}
    public string Value { get; set;}
    public DateTime SpacedRepetition_LastLearn { get; set;}
    public string Transcription { get; set;}
    // public string Sound { get; set;}//
    //public Guid? Family_Id { get; set;} //


    public Guid? SpacedRepetition_Id { get; set; } //
    public SpacedRepetitionConfigEntity? SpacedRepetition { get; set; }

    public Guid? Image_Id { get; set; } //
    public ImagesEntity? Image { get; set; }

    public Guid? Topic_Id { get; set; } //
    public TopicsEntity? Topic { get; set; }
}