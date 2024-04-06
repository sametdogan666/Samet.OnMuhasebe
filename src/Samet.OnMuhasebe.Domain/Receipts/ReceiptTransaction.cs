namespace Samet.OnMuhasebe.Receipts;

public class ReceiptTransaction : FullAuditedEntity<Guid>
{
    public Guid ReceiptId { get; set; }
    public PaymentType PaymentType { get; set; }
    public required string TrackingNo { get; set; }
    public Guid? CheckBankId { get; set; }
    public Guid? CheckBanBranchId { get; set; }
    public string? CheckAccountNo { get; set; }
    public string? DocumentNo { get; set; }
    public DateTime Maturity { get; set; }
    public string? PrincipalDebtor { get; set; }
    public string? Endorser { get; set; }
    public Guid? BankAccountId { get; set; }
    public decimal Sum { get; set; }
    public DocumentStatus DocumentStatus { get; set; }
    public bool OurOwnDocument { get; set; }
    public string? Description { get; set; }

}