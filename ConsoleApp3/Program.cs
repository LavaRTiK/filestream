using System;
using System.IO;
using System.Text;

namespace ConsoleApp3
{
     class Program
    {
        static void Main(string[] args)
        {
            //Октрыть  файл //Установить сойдинения
            //Прочитать/Записать
            //Кроктно закрыть 
            Console.OutputEncoding = Encoding.Unicode;
            using (var sw = new StreamWriter("test.txt",true,Encoding.Unicode))
            {
                sw.Write("Hello,World");
                sw.WriteLine("Hello,User");
            }

            using(var sr = new StreamReader("test.txt"))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.ReadKey(true);
        }
    }
}
