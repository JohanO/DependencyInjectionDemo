namespace PoormanDI
{
    public interface IMapper
    {
        ToDoItemViewModel ToViewModel(ToDoItemDto dto);
    }
}