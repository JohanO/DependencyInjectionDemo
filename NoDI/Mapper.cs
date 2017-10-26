using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDI
{
    public class Mapper
    {
        public ToDoItemViewModel ToViewModel(ToDoItemDto dto) =>
            new ToDoItemViewModel
            {
                Title = dto.Title,
                Completed = dto.Completed != 0,
                Due = dto.DueDate.ToString()
            };
    }
}
