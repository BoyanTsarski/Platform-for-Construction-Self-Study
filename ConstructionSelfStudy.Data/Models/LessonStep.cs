namespace ConstructionSelfStudy.Data.Models;

public class LessonStep
{
    public int Id { get; set; }
    public int Order { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Instruction { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }

    public int LessonId { get; set; }
    public Lesson Lesson { get; set; } = null!;
}