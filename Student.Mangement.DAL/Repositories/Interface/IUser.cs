
namespace Student.Mangement.DAL.Repositories.Interface;

public interface IUser : IBaseRepository<Users>
{
    AuthenticateResponse Authenticate(LoginModel model);
    IEnumerable<StudentDetailsEntity> GetAll();
    StudentDetailsEntity GetById(int id);
    bool ResetPassword(string userName, string newPassword, string oldPassword);
    void Register(IList<RegisterRequest> model);
    void Update(IList<UpdateRequest> model);
    void Delete(int id);
}
