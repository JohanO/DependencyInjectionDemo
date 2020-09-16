using System;
using System.Linq;

namespace NoDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new ToDoController();
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
