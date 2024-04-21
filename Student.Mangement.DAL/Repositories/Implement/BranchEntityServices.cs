namespace Student.Mangement.DAL.Repositories.Implement;
public class BranchEntityServices: BaseRepository<BranchEntity>, IBranchEntity
{
    private readonly StudentDbContext _context;
    public BranchEntityServices(StudentDbContext context) : base(context)
    {
        _context = context;
    }
}
