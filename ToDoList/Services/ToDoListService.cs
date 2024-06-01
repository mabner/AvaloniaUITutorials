using System.Collections.Generic;
using ToDoList.DataModel;

namespace ToDoList.Services;

public class ToDoListService
{
    public IEnumerable<ToDoItem> GetItems() => new[]
    {
        new ToDoItem { Description = "Test the water" },
        new ToDoItem { Description = "20% water change" },
        new ToDoItem { Description = "Clean the glass", IsChecked = true },
    };
}