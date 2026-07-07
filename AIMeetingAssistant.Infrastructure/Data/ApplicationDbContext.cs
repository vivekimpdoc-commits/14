using Microsoft.EntityFrameworkCore;
using AIMeetingAssistant.Core.Models;

namespace AIMeetingAssistant.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<ActionTask> ActionTasks { get; set; }
    public DbSet<Decision> Decisions { get; set; }
    public DbSet<Officer> Officers { get; set; }
    public DbSet<RiskAlert> RiskAlerts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Meeting>()
            .Property(m => m.Title)
            .IsRequired()
            .HasMaxLength(200);
            
        modelBuilder.Entity<Meeting>()
            .Property(m => m.MeetingType)
            .IsRequired()
            .HasMaxLength(100);
            
        modelBuilder.Entity<ActionTask>()
            .HasOne(a => a.AssignedOfficer)
            .WithMany()
            .HasForeignKey(a => a.AssignedOfficerId)
            .OnDelete(DeleteBehavior.Restrict);
            
        modelBuilder.Entity<ActionTask>()
            .HasOne(a => a.SourceMeeting)
            .WithMany()
            .HasForeignKey(a => a.MeetingId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
