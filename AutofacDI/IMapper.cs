namespace AutofacDI
{
    public interface IMapper
    {
        ToDoItemViewModel ToViewModel(ToDoItemDto dto);
    }
}