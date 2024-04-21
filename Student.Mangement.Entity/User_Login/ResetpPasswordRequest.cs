namespace Student.Mangement.Entity.User_Login;

public class ResetpPasswordRequest
{
    [Required]
    public string userName { get; set; }
    [Required]
    public string newPassword { get; set; }
    [Required]
    public string oldPassword { get; set; }
}

