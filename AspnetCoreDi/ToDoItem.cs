using System;

namespace AspnetCoreDi
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public short Completed { get; set; }
        public DateTime DueDate { get; set; }
    }
}
