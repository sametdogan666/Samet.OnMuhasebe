namespace Samet.OnMuhasebe.BankAccounts;

public class BankAccount : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public BankAccountType AccountType { get; set; }
    public required string AccountNo { get; set; }
    public required string IbanNo { get; set; }
    public Guid BankBranchId { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public Guid BranchId { get; set; }
    public required string Description { get; set; }
    public bool Status { get; set; }

}