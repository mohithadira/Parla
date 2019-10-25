using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveryGuru.BussinessLogic;

namespace SurveyGuru.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration registration = new Registration();

        start:
            Console.WriteLine("Welcome To SurveryGuru Pvt. Ltd.!!");
            Console.WriteLine("Enter a number as per your Choice");
            Console.WriteLine("1. To Add New Voter");
            Console.WriteLine("2. To Get Data of All Voters");
            Console.WriteLine("3. To Find/Get details a Voter with VoterId");
            Console.WriteLine("4. To Remove a Voter");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                default:
                    Console.WriteLine("Not Matched with any option");
                    Console.WriteLine("********************************************");
                    Console.WriteLine("Enter R for retry!");
                    if (Console.ReadLine() == "r")
                    {
                        Console.Clear();
                        goto start;
                    }
                    break;
                case 1:
                    try
                        {
                            Console.WriteLine("Enter following details:");
                            Console.Write("Voter Id: ");
                            string _Id = Console.ReadLine();
                            Console.Write("Voter Name: ");
                            string _Name = Console.ReadLine();
                            Console.Write("Ward: ");
                            string _Ward = Console.ReadLine();
                            Console.Write("City: ");
                            string _City = Console.ReadLine();
                            Console.Write("Party to Vote for: ");
                            string _Party = Console.ReadLine();
                            Console.Write("Reason to Vote for: ");
                            string _Reason = Console.ReadLine();

                            registration.AddVoter(_Id, _Name, _Ward, _City, _Party, _Reason);
                        }
                    catch (Exception exception)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(exception.Message);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine("Enter N for Next Operation!");
                    if (Console.ReadLine() == "n")
                    {
                        Console.Clear();
                        goto start;
                    }
                    break;
                case 2:
                    {
                        registration.ViewAllVoter();
                    }
                    Console.WriteLine("Enter N for Next Operation!");
                    if (Console.ReadLine() == "n")
                    {
                        Console.Clear();
                        goto start;
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Enter Voter ID");
                        string _Id = Console.ReadLine();
                        registration.SearchVoter(_Id);
                    }
                    catch (Exception exception)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(exception.Message);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine("Enter N for Next Operation!");
                    if (Console.ReadLine() == "n")
                    {
                        Console.Clear();
                        goto start;
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Enter Voter ID");
                        string _Id = Console.ReadLine();
                        registration.DeleteVoter(_Id);
                    }
                    catch (Exception exception)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(exception.Message);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine("Enter N for Next Operation!");
                    if (Console.ReadLine() == "n")
                    {
                        Console.Clear();
                        goto start;
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Thank You!!");
                        Environment.Exit(0);
                    }
                    break;
            }
        }
    }
}
