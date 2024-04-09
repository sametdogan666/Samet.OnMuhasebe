namespace Samet.OnMuhasebe.Branches;

public class Branch : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public bool Status { get; set; }

    public ICollection<BankAccount>? BankAccounts { get; set; }
    public ICollection<Store>? Stores { get; set; }
    public ICollection<Invoice>? Invoices { get; set; }
    public ICollection<Safe>? Safes { get; set; }
    
}