namespace Samet.OnMuhasebe.BankAccounts;

public class BankAccount : FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public BankAccountType BankAccountType { get; set; }
    public string AccountNo { get; set; }
    public string IbanNo { get; set; }
    public Guid BankBranchId { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public Guid BranchId { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }

}