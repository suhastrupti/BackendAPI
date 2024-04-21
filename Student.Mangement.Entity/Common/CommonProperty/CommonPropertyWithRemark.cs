
namespace Student.Common.CommonProperty;

public abstract class CommonPropertyWithRemark :AuditedEntity
{
    [Column(name: "status")]
    public bool status { get; set; }

    [Column(name: "remark")]
    public string Remark { get; set; }
}
