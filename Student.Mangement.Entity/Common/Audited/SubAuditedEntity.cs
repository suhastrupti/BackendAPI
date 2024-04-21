namespace Student.Common.Audited;

public abstract class SubAuditedEntity : CommonPropertyWithRemark
{
    public DateTime last_login { get; set; }
    public DateTime last_logout { get; set; }
}
