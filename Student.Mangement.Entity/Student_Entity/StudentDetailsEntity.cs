namespace Student.Mangement.Entity.Student_Entity;

public class StudentDetailsEntity:CommonProperties
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StudentID { get; set; }
    public string? StudentCode { get; set; }
    public int RoleId { get; set; }
    public RoleEntity Role { get; set; }
    public int LocationId { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }

    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
}
