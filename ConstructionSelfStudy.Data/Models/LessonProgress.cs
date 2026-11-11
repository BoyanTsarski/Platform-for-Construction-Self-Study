namespace ConstructionSelfStudy.Data.Models;

public class LessonProgress
{
    public int Id { get; set; }
    public DateTime CompletedOn { get; set; } = DateTime.UtcNow;

    public string UserId { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;

    public int LessonId { get; set; }
    public Lesson Lesson { get; set; } = null!;
}