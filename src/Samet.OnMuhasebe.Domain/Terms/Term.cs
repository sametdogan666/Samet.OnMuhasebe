namespace Samet.OnMuhasebe.Terms;

public class Term : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }

    public ICollection<Invoice>? Invoices { get; set; }
    public ICollection<Receipt>? Receipts { get; set; }
    public ICollection<CompanyParameter>? CompanyParameters { get; set; }
}