namespace Samet.OnMuhasebe.Currents;

public class Current : FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string TaxOffice { get; set; }
    public string TaxNo { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
}