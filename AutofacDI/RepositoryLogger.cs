using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDI
{
    public class RepositoryLogger : IToDoItemRepository
    {
        private readonly IToDoItemRepository repository;

        public RepositoryLogger(IToDoItemRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<ToDoItemDto> GetAllItems()
        {
            Debug.WriteLine("GetAllItems called");
            var data = this.repository.GetAllItems();
            Debug.WriteLine($"Number of items = {data.Count()}");

            return data;
        }
    }
}
