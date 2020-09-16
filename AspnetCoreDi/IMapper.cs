namespace AspnetCoreDi
{
    public interface IMapper
    {
        ToDoItemViewModel ToViewModel(ToDoItem dto);
    }
}