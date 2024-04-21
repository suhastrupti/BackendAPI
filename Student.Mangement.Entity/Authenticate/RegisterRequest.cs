namespace Student.Authenticate;

public class RegisterRequest
{
    [Required]
    public string userName { get; set; }

    [Required]
    public string password { get; set; }
  
}
