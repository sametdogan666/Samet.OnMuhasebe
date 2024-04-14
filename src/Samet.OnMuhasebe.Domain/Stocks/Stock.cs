namespace Samet.OnMuhasebe.Stocks;

public class Stock : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public int VatRate { get; set; }
    public decimal UnitPrice { get; set; }
    public  string? Barcode { get; set; }
    public Guid UnitId { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }

    public required Unit Unit { get; set; }
    public SpecialCode? SpecialCode1 { get; set; }
    public SpecialCode? SpecialCode2 { get; set; }

    public ICollection<InvoiceTransaction>? InvoiceTransactions { get; set; }
}