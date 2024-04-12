namespace Samet.OnMuhasebe.Currents;

public class Current : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; } 
    public required string Name { get; set; } 
    public string? TaxOffice { get; set; }
    public string? TaxNo { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }

    public SpecialCode? SpecialCode1 { get; set; }
    public SpecialCode? SpecialCode2 { get; set; }

    public ICollection<Invoice>? Invoices { get; set; }
    public ICollection<Receipt>? Receipts { get; set; }

}