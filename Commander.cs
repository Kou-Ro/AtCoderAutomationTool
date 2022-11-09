﻿

namespace AtCoderAutomationTool
{
   class Program
   {
      public static void Main(string[] args)
      {
         Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AtCoderAutomationTool\\templates");
         while (true)
         {
            Console.Write("Command :");
            string[] commands = Console.ReadLine()!.Split();
            if (commands[0] == "build")
            {
               Build.Run();
            }
            else if (commands[0] == "quit") break;
            else if (commands[0] == "") Console.Error.WriteLine("Please enter some command.");
            else Console.Error.WriteLine("The command not found :" + commands[0]);
            Console.WriteLine();
         }
      }
   }
}