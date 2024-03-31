﻿namespace Samet.OnMuhasebe.Units;

public class Unit:FullAuditedAggregateRoot<Guid>
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public Guid? SpecialCode1Id { get; set; }
    public Guid? SpecialCode2Id { get; set; }
    public required string Description { get; set; }
    public bool Status { get; set; }
}