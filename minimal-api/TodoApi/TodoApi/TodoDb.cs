using Microsoft.EntityFrameworkCore;

namespace TodoApi
{
    public class TodoDb : DbContext
    {
        public DbSet<TodoItem> Todos { get; set; }
        public TodoDb( DbContextOptions<TodoDb> options )
            : base( options )
        {
        }
    }
}
