using Microsoft.EntityFrameworkCore;

namespace PickWinner.Models
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {

        }
    }
}
