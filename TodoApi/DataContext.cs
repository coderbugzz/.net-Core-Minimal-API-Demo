using Microsoft.EntityFrameworkCore;

namespace TodoApi
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<ToDo> ToDo =>Set <ToDo> ();
    }
}
