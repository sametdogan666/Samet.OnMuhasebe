namespace Samet.OnMuhasebe.Parameters;

public class CompanyParameter : Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid BranchId { get; set; }
    public Guid TermId { get; set; }
    public Guid? StoreId { get; set; }

    public required IdentityUser User { get; set; }
    public required Branch Branch { get; set; }
    public required Term Term { get; set; }
    public Store? Store { get; set; }
}