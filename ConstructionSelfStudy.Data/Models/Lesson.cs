namespace ConstructionSelfStudy.Data.Models;

public class Lesson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string? MaterialsNeeded { get; set; }
    public string? ToolsNeeded { get; set; }
    public int Order { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;

    public ICollection<LessonStep> Steps { get; set; } = new List<LessonStep>();
}