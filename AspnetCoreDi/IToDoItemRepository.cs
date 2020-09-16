using System.Collections.Generic;

namespace AspnetCoreDi
{
    public interface IToDoItemRepository
    {
        IEnumerable<ToDoItem> GetAllItems();
    }
}