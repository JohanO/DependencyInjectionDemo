using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetCoreDi
{
    public class Mapper : IMapper
    {
        public ToDoItemViewModel ToViewModel(ToDoItem dto) =>
            new ToDoItemViewModel
            {
                Title = dto.Title,
                Completed = dto.Completed != 0,
                Due = dto.DueDate.ToString()
            };
    }
}
