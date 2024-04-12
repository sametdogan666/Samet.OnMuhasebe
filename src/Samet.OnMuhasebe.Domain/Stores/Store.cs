namespace Samet.OnMuhasebe.Stores;

public class Store : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public Guid BranchId { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }

    public SpecialCode? SpecialCode1 { get; set; }
    public SpecialCode? SpecialCode2 { get; set; }
    public required Branch Branch { get; set; }

    public ICollection<CompanyParameter>? CompanyParameters { get; set; }
    public ICollection<InvoiceTransaction>? InvoiceTransactions { get; set; }
}