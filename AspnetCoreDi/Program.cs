using System;
using Microsoft.Extensions.DependencyInjection;

namespace AspnetCoreDi
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var provider = services.BuildServiceProvider();

            var controller = provider.GetRequiredService<ToDoController>();
            DisplayToDoItems(controller);
        }

        static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMapper, Mapper>();
            services.AddTransient<IToDoItemRepository, ToDoItemRepository>();
            services.AddTransient<ToDoController>();
        }

        static void DisplayToDoItems(ToDoController controller)
        {
            var items = controller.Get();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Title}, {item.Completed}, {item.Due}");
            }
        }
    }
}
