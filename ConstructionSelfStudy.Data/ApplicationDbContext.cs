using ConstructionSelfStudy.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ConstructionSelfStudy.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Lesson> Lessons => Set<Lesson>();
    public DbSet<LessonStep> LessonSteps => Set<LessonStep>();
    public DbSet<LessonProgress> LessonProgresses => Set<LessonProgress>();
    public DbSet<SavedLesson> SavedLessons => Set<SavedLesson>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<SavedLesson>()
            .HasKey(s => new { s.UserId, s.LessonId });

        builder.Entity<LessonProgress>()
            .HasIndex(p => new { p.UserId, p.LessonId })
            .IsUnique();

        builder.Entity<Course>()
            .HasOne(c => c.Author)
            .WithMany()
            .HasForeignKey(c => c.AuthorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "a1000000-0000-0000-0000-000000000001",
                Name = "Learner",
                NormalizedName = "LEARNER",
                ConcurrencyStamp = "a1000000-0000-0000-0000-000000000001"
            },
            new IdentityRole
            {
                Id = "a1000000-0000-0000-0000-000000000002",
                Name = "Author",
                NormalizedName = "AUTHOR",
                ConcurrencyStamp = "a1000000-0000-0000-0000-000000000002"
            },
            new IdentityRole
            {
                Id = "a1000000-0000-0000-0000-000000000003",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
                ConcurrencyStamp = "a1000000-0000-0000-0000-000000000003"
            });

        builder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Основи на строителството" },
            new Category { Id = 2, Name = "Зидария" },
            new Category { Id = 3, Name = "Мазилка и шпакловка" },
            new Category { Id = 4, Name = "Плочки и настилки" },
            new Category { Id = 5, Name = "Боядисване" });
    }
}