using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 3; 
            int y = 3;
            y = y +2;

            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
             Console.WriteLine(y);
            x+=2;
             Console.WriteLine(x);
    
            bool isSuccess = true;
            bool isCompleted = false;

            if (isCompleted && isSuccess) 
             Console.WriteLine(true);
        
        }
    }
}
