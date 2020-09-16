using System;

namespace PoormanDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new RepositoryTimer(new ToDoItemRepository());
            var mapper = new Mapper();
            var controller = new ToDoController(repository, mapper);
            DisplayToDoItems(controller);
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
