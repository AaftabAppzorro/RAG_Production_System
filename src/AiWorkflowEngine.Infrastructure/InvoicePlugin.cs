
using Microsoft.SemanticKernel;

namespace AiWorkflowEngine.Infrastructure;

public class InvoicePlugin
{
    [KernelFunction]
    public string CreateInvoice(string customerName, decimal amount)
    {
        return $"Invoice created for {customerName} with amount {amount}";
    }
}
