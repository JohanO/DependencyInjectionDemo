using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoormanDI
{
    public class ToDoItemDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public short Completed { get; set; }
        public DateTime DueDate { get; set; }
    }
}
