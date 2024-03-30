﻿namespace Samet.OnMuhasebe.Stores;

public class Store : FullAuditedAggregateRoot<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public Guid BranchId { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
}