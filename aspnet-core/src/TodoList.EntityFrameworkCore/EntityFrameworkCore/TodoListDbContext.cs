using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TodoList.Authorization.Roles;
using TodoList.Authorization.Users;
using TodoList.MultiTenancy;

namespace TodoList.EntityFrameworkCore
{
    public class TodoListDbContext : AbpZeroDbContext<Tenant, Role, User, TodoListDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TodoListDbContext(DbContextOptions<TodoListDbContext> options)
            : base(options)
        {
        }
    }
}
