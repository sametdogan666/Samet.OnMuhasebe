using Volo.Abp.Domain.Entities;

namespace Samet.OnMuhasebe.Parameters;

public class CompanyParameter : Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid BranchId { get; set; }
    public Guid TermId { get; set; }
    public Guid? StoreId { get; set; }

}