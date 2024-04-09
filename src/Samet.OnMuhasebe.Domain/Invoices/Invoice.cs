namespace Samet.OnMuhasebe.Bills;

public class Invoice : FullAuditedAggregateRoot<Guid>
{
    public InvoiceType InvoiceType { get; set; }
    public required string InvoiceNo { get; set; }
    public DateTime Date { get; set; }
    public decimal GrossAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal ExcludesVat { get; set; }
    public decimal VatAmount { get; set; }
    public decimal NetAmount { get; set; }
    public int NumberOfTransactions { get; set; }
    public Guid CurrentId { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public Guid BranchId { get; set; }
    public Guid TermId { get; set; }
    public required string Description { get; set; }
    public bool Status { get; set; }

    public required Current Current { get; set; }
    public SpecialCode? SpecialCode1 { get; set; }
    public SpecialCode? SpecialCode2 { get; set; }
    public required Branch Branch { get; set; }
    public required Term Term { get; set; }

    public ICollection<InvoiceTransaction>? InvoiceTransactions { get; set; }

}