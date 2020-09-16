using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDI
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public short Completed { get; set; }
        public DateTime DueDate { get; set; }
    }
}
