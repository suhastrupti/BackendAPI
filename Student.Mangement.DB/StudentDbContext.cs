using Student.Mangement.Entity.Branch_Admin;
using Student.Mangement.Entity.BranchEntity;

namespace Student.Mangement.DB;

public class StudentDbContext: DbContext
{
    public StudentDbContext() : base()
    {

    }

    public StudentDbContext(DbContextOptions<StudentDbContext> option) :
        base(option)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = "Server=AMIT\\MSSQLSERVER2019;Database=JanataShikshanDB;Integrated Security=true; TrustServerCertificate = True; MultipleActiveResultSets= True;Max Pool Size=200;";
         
            optionsBuilder.UseSqlServer(connectionString,
                options => options.EnableRetryOnFailure());
        }
    }
    public DbSet<Users> Users { get; set; }
    public DbSet<StudentDetailsEntity> StudentDetails { get; set; }
    public DbSet<BranchAdmin> BranchAdmins { get; set; }
    public DbSet<BranchEntity> Branches { get; set; }
}
