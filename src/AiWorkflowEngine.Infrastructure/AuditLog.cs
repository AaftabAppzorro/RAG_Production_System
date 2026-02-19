
namespace AiWorkflowEngine.Infrastructure;

public class AuditLog
{
    public int Id { get; set; }
    public string? UserId { get; set; }
    public string? Action { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
