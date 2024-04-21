namespace Student.Mangement.Entity.BranchEntity;

public class BranchEntity:CommonProperties
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int branchID { get; set; }
    public string BranchName { get; set; }


}
