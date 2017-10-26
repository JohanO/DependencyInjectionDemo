using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDI
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        public IEnumerable<ToDoItemDto> GetAllItems() =>
            new List<ToDoItemDto>
            {
                new ToDoItemDto { Id = Guid.NewGuid(), Title = "First item", Completed = 0, DueDate = new DateTime(2017, 10, 20) },
                new ToDoItemDto { Id = Guid.NewGuid(), Title = "Second item", Completed = 1, DueDate = new DateTime(2017, 11, 02) },
                new ToDoItemDto { Id = Guid.NewGuid(), Title = "Thrid item", Completed = 0, DueDate = new DateTime(2017, 10, 24) },
                new ToDoItemDto { Id = Guid.NewGuid(), Title = "Fourth item", Completed = 0, DueDate = new DateTime(2017, 10, 25) },
            };
    }
}
