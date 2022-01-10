using System;
using System.Collections.Generic;
namespace todo_app_csharp
{
    class TodoOperations
    {
        public void ViewTodoList(List<Todo> todoList) {
            FindResults(todoList, 0);
            FindResults(todoList, 1);
            FindResults(todoList, 2);
        }
        public void FindResults(List<Todo> todoList, int status) {
            List<Todo> results = todoList.FindAll(todo=> todo.GetStatus()==status);
            if(status==0){
                Console.WriteLine("TODO Line");
                Console.WriteLine("************************");
            }
            else if(status==1) {
                Console.WriteLine("IN PROGRESS Line");
                Console.WriteLine("************************");
            }
            else if(status==2) {
                Console.WriteLine("DONE Line");
                Console.WriteLine("************************");
            }

            if (results.Count==0) {
                Console.WriteLine("~ BOŞ ~");
            }
            else {
                foreach (var todo in results) {
                    todo.TodoDetails();
                }
            }

        }
    }
}
