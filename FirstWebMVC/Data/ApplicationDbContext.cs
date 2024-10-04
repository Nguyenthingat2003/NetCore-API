namespace FirstWebMVC.Data
{
    public class applicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<applicationDbContext> options) : base(options)
        {}
        public DdSet<Person> Person { get; set;}
        
        public DdSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set;} = default!;

        public DdSet<DaiLy> DaiLy { get; set;} = default!;

        public DdSet<Costomer> Costomer { get; set;} = default!;

                }
    }