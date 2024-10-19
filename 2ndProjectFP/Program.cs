using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace _2ndProjectFP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m =1;
            long id=0;
            string name="";
            int phone=0;
            FileStream file = new FileStream(@"F:\my work spacee\myProject.txt", FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            while (m>0)
            {
            Console.WriteLine("Enter 'a' to add new student");
            Console.WriteLine("Enter 'd' to display all student");
                Console.Write("Enter your choice: ");
                char choice=char.Parse(Console.ReadLine());
                if (choice =='a')
                {
                    Console.Write("Enter student id: ");
                    id = long.Parse(Console.ReadLine());
                    Console.Write("Enter student name: ");
                     name= Console.ReadLine();                    
                    Console.Write("Enter student phone: ");
                     phone = Convert.ToInt32(Console.ReadLine());
                }
                else if (choice == 'd')
                {
                    while (m > 0)
                    {
                        Console.WriteLine("Student id is: {0}", id);
                        Console.WriteLine("Student id is: {0}", name);
                        Console.WriteLine("Student id is: {0}", phone);
                    }
                }
                Console.Write("Do you want to continue? y/n: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine("\n");
                if (keyInfo.Key == ConsoleKey.Y)
                {
                    writer.WriteLine(id);
                    writer.WriteLine(name);
                    writer.WriteLine(phone); 
                    continue;
                }
                else if (keyInfo.Key == ConsoleKey.N)
                {
                    
                    break;
                }
            }
             writer.Flush();
             writer.Close();
             file.Close();//done
        }
    }
}
