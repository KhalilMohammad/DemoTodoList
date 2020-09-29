using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TodoList.Configuration;
using TodoList.Web;

namespace TodoList.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TodoListDbContextFactory : IDesignTimeDbContextFactory<TodoListDbContext>
    {
        public TodoListDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TodoListDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TodoListDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TodoListConsts.ConnectionStringName));

            return new TodoListDbContext(builder.Options);
        }
    }
}
