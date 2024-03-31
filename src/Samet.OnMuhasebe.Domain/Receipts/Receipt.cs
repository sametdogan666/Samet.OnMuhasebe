namespace Samet.OnMuhasebe.Receipts;

public class Receipt : FullAuditedAggregateRoot<Guid>
{
    public ReceiptType ReceiptType { get; set; }
    public required string ReceiptNo { get; set; }
    public DateTime Date { get; set; }
    public Guid? CurrentId { get; set; }
    public Guid? SafeId { get; set; }
    public Guid? BankAccountId { get; set; }
    public int NumberOfTransactions { get; set; }
    public decimal CheckTotal { get; set; }
    public decimal BillTotal { get; set; }
    public decimal PosTotal { get; set; }
    public decimal CashTotal { get; set; }
    public decimal BankTotal { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public Guid BranchId { get; set; }
    public Guid TermId { get; set; }
    public required string Description { get; set; }
    public bool Status { get; set; }
}