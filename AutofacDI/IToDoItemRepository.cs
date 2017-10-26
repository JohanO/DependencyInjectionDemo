using System.Collections.Generic;

namespace AutofacDI
{
    public interface IToDoItemRepository
    {
        IEnumerable<ToDoItemDto> GetAllItems();
    }
}