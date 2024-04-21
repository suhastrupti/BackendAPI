namespace Student.Mangement.Entity.Branch_Admin;

public class BranchAdmin:CommonProperties
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int branchID { get; set; } 
    public string username { get; set; }
  //  public int SchoolId { get; set; }
    public string BranchName { get; set; }
    public string UDIS_Number { get;set; }
    public string ContactNumber { get; set; }
    public string EmailAddress { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string password { get; set; }
    

}
