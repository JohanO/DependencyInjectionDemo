using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDI
{
    public class MainPageViewModel
    {
        public MainPageViewModel(IToDoItemRepository repository, IMapper mapper)
        {
            var items = repository.GetAllItems().Select(mapper.ToViewModel);
            this.ToDoItems = new ObservableCollection<ToDoItemViewModel>(items);
        }

        public ObservableCollection<ToDoItemViewModel> ToDoItems { get; }
    }
}
