namespace Samet.OnMuhasebe.BankAccounts;

public class BankAccount : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public BankAccountType AccountType { get; set; }
    public required string AccountNo { get; set; }
    public string? IbanNo { get; set; }
    public Guid BankBranchId { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public Guid BranchId { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }

    public required BankBranch BankBranch { get; set; }
    public SpecialCode? SpecialCode1 { get; set; }
    public SpecialCode? SpecialCode2 { get; set; }
    public Branch? Branch { get; set; }

    public ICollection<Receipt>? Receipts { get; set; }
    public ICollection<Receipts.ReceiptTransaction>? ReceiptTransactions { get; set; }
}