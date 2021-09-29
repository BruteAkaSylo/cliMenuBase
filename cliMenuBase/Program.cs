using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using System.Threading;
using System.Diagnostics;

namespace cliMenuBase
{
    class Program
    {
        static void Main(string[] args)
        {


        startOfProgram:
            Console.Title = "cliMenuBase";

            //Console.WindowHeight = 8; Change console height after adding all options to make the console the same size as the menu
            //Console.WindowWidth = 25; Change console width after adding all options to make the console the same size as the menu

            Random rnd = new Random();

            Process Proc = new Process();

            int sleepTimeout = rnd.Next(1, 501);
            int selectedClass = ConsoleHelper.MultipleChoice(true, "Option 1", "Option 2", "Option 3");

            if(selectedClass == 0)
            {
                Console.Clear();
                Console.WriteLine("Starting Option 1!", Color.Magenta);
                Thread.Sleep(sleepTimeout);
                Process process = Process.Start(@"Path to option 1");
                int id = process.Id;
                Process tempProc = Process.GetProcessById(id);
                Console.WriteLine("Started!", Color.Magenta);
                Console.Write("Going back in ", Color.Magenta);
                for (int a = 4; a >= 0; a--)
                {
                    Console.CursorLeft = 14;
                    int b = a + 1;
                    Console.Write("{0} ", b, Color.Magenta);    // Add space to make sure to override previous contents
                    System.Threading.Thread.Sleep(1000);
                }
                goto startOfProgram;
            }
            else if (selectedClass == 1)
            {
                Console.Clear();
                Console.WriteLine("Starting Option 2", Color.Magenta);
                Thread.Sleep(sleepTimeout);
                Process process = Process.Start(@"Path to option 2");
                int id = process.Id;
                Process tempProc = Process.GetProcessById(id);
                Console.WriteLine("Started!", Color.Magenta);
                Console.Write("Going back in ", Color.Magenta);
                for (int a = 4; a >= 0; a--)
                {
                    Console.CursorLeft = 14;
                    int b = a + 1;
                    Console.Write("{0} ", b, Color.Magenta);    // Add space to make sure to override previous contents
                    System.Threading.Thread.Sleep(1000);
                }
                goto startOfProgram;
            }
            else if (selectedClass == 2)
            {
                Console.Clear();
                Console.WriteLine("Starting Option 3", Color.Magenta);
                Thread.Sleep(sleepTimeout);
                Process process = Process.Start(@"Path to option 3");
                int id = process.Id;
                Process tempProc = Process.GetProcessById(id);
                Console.WriteLine("Started!", Color.Magenta);
                Console.Write("Going back in ", Color.Magenta);
                for (int a = 4; a >= 0; a--)
                {
                    Console.CursorLeft = 14;
                    int b = a + 1;
                    Console.Write("{0} ", b, Color.Magenta);    // Add space to make sure to override previous contents
                    System.Threading.Thread.Sleep(1000);
                }
                goto startOfProgram;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Option", Color.Magenta);
                Thread.Sleep(sleepTimeout);
                Console.Write("Going back in ", Color.Magenta);
                for (int a = 4; a >= 0; a--)
                {
                    Console.CursorLeft = 14;
                    int b = a + 1;
                    Console.Write("{0} ", b, Color.Magenta);    // Add space to make sure to override previous contents
                    System.Threading.Thread.Sleep(1000);
                }
                goto startOfProgram;
            }

            Console.ReadLine();
        }
    }
}
