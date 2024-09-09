using Microsoft.EntityFrameworkCore;
using DSM.Models;

namespace DSM.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BOARD_POST_CLS> BOARD_POST_CLSs { get; set; }
    }
}
