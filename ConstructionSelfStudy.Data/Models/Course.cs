namespace ConstructionSelfStudy.Data.Models;

public enum ContentStatus { Draft, PendingApproval, Approved, Rejected }

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Difficulty { get; set; } 
    public ContentStatus Status { get; set; } = ContentStatus.Draft;
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public string AuthorId { get; set; } = string.Empty;
    public ApplicationUser Author { get; set; } = null!;

    public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
}