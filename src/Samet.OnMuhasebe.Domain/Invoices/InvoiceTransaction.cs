namespace Samet.OnMuhasebe.Bills;

public class InvoiceTransaction : FullAuditedEntity<Guid>
{
    public Guid InvoiceId { get; set; }
    public InvoiceTransactionType TransactionType { get; set; }
    public Guid? StockId { get; set; }
    public Guid? ServiceId { get; set; }
    public Guid? ExpenseId { get; set; }
    public Guid? StoreId { get; set; }
    public decimal Amount { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal GrossAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public int VatRate { get; set; }
    public decimal ExcludesVat { get; set; }
    public decimal VatAmount { get; set; }
    public decimal NetAmount { get; set; }
    public string? Description { get; set; }

    public required Invoice Invoice { get; set; }
    public Stock? Stock { get; set; }
    public Service? Service { get; set; }
    public Expense? Expense { get; set; }
    public Store? Store { get; set; }
}