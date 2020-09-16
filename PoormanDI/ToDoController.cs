using System.Collections.Generic;
using System.Linq;

namespace PoormanDI
{
    public class ToDoController
    {
        private readonly IToDoItemRepository _repository;
        private readonly IMapper _mapper;

        public ToDoController(IToDoItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<ToDoItemViewModel> Get()
        {
            var items = _repository.GetAllItems().Select(_mapper.ToViewModel);
            return items;
        }
    }
}
