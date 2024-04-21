using Student.Mangement.DAL.Repositories.Interface;
using Student.Mangement.DB;
using Student.Mangement.Entity.Branch_Admin;

namespace Student.Mangement.DAL.Repositories.Implement;

public class BranchAdminServices : BaseRepository<BranchAdmin>, IBranchAdmin
{
    private readonly StudentDbContext _context;
    public BranchAdminServices(StudentDbContext context) : base(context)
    {
        _context = context;
    }
}
