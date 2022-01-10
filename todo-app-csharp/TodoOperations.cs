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
            List<Todo> results = todoList.FindAll(todo=> todo.GetStatus() == status);
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
                Console.WriteLine();
            }
            else {
                foreach (var todo in results) {
                    todo.TodoDetails();
                    Console.WriteLine();
                }
            }

        }
    
        // public void UpdateStatus(Todo todo, int status) {
        //     todo.SetStatus(status);
        // }

        public void DeleteTodo(List<Todo> todoList){
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();

            List<Todo> result = todoList.FindAll(x=> x.GetTitle() == input);

            if(result.Count != 0 ){
                foreach (Todo item in result)
                {
                    todoList.Remove(item);
                }
                Console.WriteLine("Silme işlemi tamamlandı");
            }
            else {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int option = Convert.ToInt16(Console.ReadLine());
                if(option == 2) { DeleteTodo(todoList);}
                else {Console.WriteLine("Silme işlemi iptal edildi.");}
            }
            
        }

    }
}
