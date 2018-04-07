using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_test_console_
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Task(() => {
                Console.WriteLine("Begin");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Finish");
            });
            Console.WriteLine("Before Start:"+task.Status);
            task.Start();
            Console.WriteLine("After Start:" + task.Status);
            Console.WriteLine("Before Wait:" + task.Status);
            task.Wait();
            Console.WriteLine("After Wait:" + task.Status);
            Console.Read();
        }
    }
}
