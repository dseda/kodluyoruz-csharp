using System;
using System.Collections.Generic;
namespace todo_app_csharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            TodoOperations ops = new TodoOperations();
            Dictionary<int, string> members = new Dictionary<int, string>();
            members.Add(1, "Seda Demir");
            members.Add(2, "Canan Yılmaz");
            members.Add(3, "Can Mert");
            members.Add(4, "Canan Mert");

            Todo todo1 = new Todo("todo app", "c sharp", 1, 2, 1);
            Todo todo2 = new Todo("contacts app", "c#", 1, 2, 2);
            Todo todo3 = new Todo("coderbyte challange", "c sharp", 1, 2);
            
            List<Todo> todoList = new List<Todo>();

            todoList.Add(todo1);
            todoList.Add(todo2);
            todoList.Add(todo3);

            ops.ViewTodoList(todoList);
            


            
        }
    }
}
