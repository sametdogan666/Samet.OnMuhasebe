namespace Samet.OnMuhasebe.SpecialCodes;

public class SpecialCode : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public SpecialCodeType SpecialCodeType { get; set; }
    public CardType CardType { get; set; }
    public required string Description { get; set; }
    public bool Status { get; set; }

    public ICollection<BankAccount>? SpecialCode1BankAccounts { get; set; }
    public ICollection<BankAccount>? SpecialCode2BankAccounts { get; set; }
    public ICollection<Bank>? SpecialCode1Banks { get; set; }
    public ICollection<Bank>? SpecialCode2Banks{ get; set; }
    public ICollection<BankBranch>? SpecialCode1BankBranches { get; set; }
    public ICollection<BankBranch>? SpecialCode2BankBranches{ get; set; }
    public ICollection<Unit>? SpecialCode1Units { get; set; }
    public ICollection<Unit>? SpecialCode2Units{ get; set; }
    public ICollection<Current>? SpecialCode1Currents { get; set; }
    public ICollection<Current>? SpecialCode2Currents{ get; set; }
    public ICollection<Store>? SpecialCode1Stores { get; set; }
    public ICollection<Store>? SpecialCode2Stores{ get; set; }
    public ICollection<Invoice>? SpecialCode1Invoices { get; set; }
    public ICollection<Invoice>? SpecialCode2Invoices{ get; set; }
    public ICollection<Service>? SpecialCode1Services { get; set; }
    public ICollection<Service>? SpecialCode2Services{ get; set; }
    public ICollection<Safe>? SpecialCode1Safes { get; set; }
    public ICollection<Safe>? SpecialCode2Safes{ get; set; }



}