using System;
using System.Collections.Generic;
namespace todo_app_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> members = new Dictionary<int, string>();
            members.Add(1, "Seda Demir");
            members.Add(2, "Canan Yılmaz");
            members.Add(3, "Can Mert");
            members.Add(4, "Canan Mert");
            
            Todo todo = new Todo("todo app", "c sharp", 1, 2,3);
            todo.TodoDetails();

            
        }
    }
}
