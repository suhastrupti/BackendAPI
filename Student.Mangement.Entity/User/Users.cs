namespace Student.Mangement.Entity.User;

public class Users:CommonProperties
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string userName { get; set; }

    //  [JsonIgnore]
    public string PasswordHash { get; set; }
}
