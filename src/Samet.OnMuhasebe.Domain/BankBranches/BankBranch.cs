namespace Samet.OnMuhasebe.BankBranches;

public class BankBranch:FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public Guid BankId { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }

    public required Bank Bank { get; set; }
    public SpecialCode? SpecialCode1 { get; set; }
    public SpecialCode? SpecialCode2 { get; set; }

    public ICollection<BankAccount>? BankAccounts { get; set; }
    public ICollection<Receipts.ReceiptTransaction>? ReceiptTransactions { get; set; }
}