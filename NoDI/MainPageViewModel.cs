using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDI
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            var repository = new ToDoItemRepository();
            var mapper = new Mapper();
            var items = repository.GetAllItems().Select(mapper.ToViewModel);

            this.ToDoItems = new ObservableCollection<ToDoItemViewModel>(items);
        }

        public ObservableCollection<ToDoItemViewModel> ToDoItems { get; }
    }
}
