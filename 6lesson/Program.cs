using System;
using System.Diagnostics;
using System.Linq;

namespace _6lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var procList = Process.GetProcesses();
            foreach (var proc in procList)
            {
                Console.WriteLine($"{proc.Id} {proc.ProcessName}");
            }
            Console.Write("name = ");
            var name = Console.ReadLine();
            try
            {
                procList.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill();
                Console.WriteLine($"{name} deleted!");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"Process {name} not found!");
            }
        }
    }
}
