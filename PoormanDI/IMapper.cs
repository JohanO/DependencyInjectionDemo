﻿namespace PoormanDI
{
    public interface IMapper
    {
        ToDoItemViewModel ToViewModel(ToDoItem dto);
    }
}