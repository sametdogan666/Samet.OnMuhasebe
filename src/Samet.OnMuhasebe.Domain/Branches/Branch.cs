namespace Samet.OnMuhasebe.Branches;

public class Branch : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public bool Status { get; set; }
}