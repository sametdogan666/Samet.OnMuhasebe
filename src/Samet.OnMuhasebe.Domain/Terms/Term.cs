namespace Samet.OnMuhasebe.Terms;

public class Term : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public bool Status { get; set; }

    public ICollection<Invoice>? Invoices { get; set; }
}