using System.Collections.Generic;
using System.Linq;

namespace NoDI
{
    public class ToDoController
    {
        public IEnumerable<ToDoItemViewModel> Get()
        {
            var repository = new ToDoItemRepository();
            var mapper = new Mapper();
            var items = repository.GetAllItems().Select(mapper.ToViewModel);

            return items;
        }
    }
}
