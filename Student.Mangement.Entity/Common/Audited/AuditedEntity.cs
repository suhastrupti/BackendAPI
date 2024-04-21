namespace Student.Common.Audited;

public abstract class AuditedEntity
{
    [Column(name: "CreatedDate")]
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    [Column(name: "CreatedBy")]
    public int CreatedBy { get; set; } = 0;

    [Column(name: "ModifiedDate")]
    public DateTime ModifiedDate { get; set; } = DateTime.Now;

    [Column(name: "ModifiedBy")]
    public int ModifiedBy { get; set; } = 0;

}
