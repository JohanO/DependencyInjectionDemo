using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PoormanDI
{
    public class RepositoryTimer : IToDoItemRepository
    {
        private readonly IToDoItemRepository _repository;

        public RepositoryTimer(IToDoItemRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ToDoItem> GetAllItems()
        {
            Console.WriteLine("GetAllItems called. Starting timer");
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var data = _repository.GetAllItems();

            stopwatch.Stop();
            Console.WriteLine($"Got {data.Count()} items in {stopwatch.ElapsedMilliseconds} milliseconds");

            return data;
        }
    }
}
