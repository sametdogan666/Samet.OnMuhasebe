namespace Samet.OnMuhasebe.Expenses;

public class Expense : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public int VatAmount { get; set; }
    public decimal UnitPrice { get; set; }
    public required string Barcode { get; set; }
    public Guid UnitId { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public required string Description { get; set; }
    public bool Status { get; set; }
}