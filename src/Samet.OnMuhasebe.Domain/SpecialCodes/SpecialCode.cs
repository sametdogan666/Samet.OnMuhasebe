namespace Samet.OnMuhasebe.SpecialCodes;

public class SpecialCode : FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public SpecialCodeType SpecialCodeType { get; set; }
    public CardType CardType { get; set; }
    public required string Description { get; set; }
    public bool Status { get; set; }

}