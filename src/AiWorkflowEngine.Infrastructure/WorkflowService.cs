
using Microsoft.SemanticKernel;

namespace AiWorkflowEngine.Infrastructure;

public class WorkflowService
{
    private readonly IConfiguration _config;
    private readonly AppDbContext _context;

    public WorkflowService(IConfiguration config, AppDbContext context)
    {
        _config = config;
        _context = context;
    }

    public async Task<object> ExecuteAsync(string instruction, string userId)
    {
        var kernel = Kernel.CreateBuilder()
            .AddAzureOpenAIChatCompletion(
                deploymentName: "gpt-4o",
                endpoint: _config["AZURE_OPENAI_ENDPOINT"],
                apiKey: _config["AZURE_OPENAI_KEY"])
            .Build();

        kernel.Plugins.AddFromObject(new InvoicePlugin());

        var result = await kernel.InvokePromptAsync(instruction);

        _context.AuditLogs.Add(new AuditLog
        {
            UserId = userId,
            Action = instruction
        });

        await _context.SaveChangesAsync();

        return new
        {
            Result = result.ToString()
        };
    }
}
