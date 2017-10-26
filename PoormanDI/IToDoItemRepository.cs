using System.Collections.Generic;

namespace PoormanDI
{
    public interface IToDoItemRepository
    {
        IEnumerable<ToDoItemDto> GetAllItems();
    }
}