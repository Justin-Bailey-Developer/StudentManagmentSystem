using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG7311_ICE2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList.Students = FileManager.ReadFile(); //Read the text file and store it in a list

            DisplayMenu();
        }

        static void DisplayMenu()
        {

            string choice = "";

            while (choice != "x") //exit if the user enters "x"
            {

                Console.WriteLine("\nEnter one of the following: \n" +
                                    "A) Display full time students \n" +
                                    "B) Display part time students \n" +
                                    "X) Exit program");

                choice = Console.ReadLine().ToLower();

                //check if the user entered a valid choice
                if (!ValidateInput(choice))
                {
                    Console.WriteLine("\nAn incorrect value was entered, please try again.");
                }

            }
        }
        
        //Check that the user entered a valid option
        static bool ValidateInput(string choice)
        {

            string check = "a b c x";
            string input = choice.Trim();
            bool flag = true;

            if (input.Length == 1 && check.Contains(input))
            {
                //check that the user does not want to quit the program
                if (!input.Equals("x"))
                {
                    //flag stays true, and the program will execute the task the user selected
                    ProcessChoice(input);
                }
                else
                {
                    //exit the program gracefully
                    Console.WriteLine("Exiting program. Goodbye!");
                    System.Environment.Exit(-1);
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        //Peform the task the user has selected
        static void ProcessChoice(string choice)
        {

            string input = choice;

            switch (choice)
            {
                case "a": //display a list of full time students
                    {
                        List<Student> fullTimeList = StudentList.Students.
                        Where(x => x.GetType() == typeof(FulltimeStudent))
                        .ToList();

                        for (int x = 0; x < fullTimeList.Count; x++)
                        {
                            Console.WriteLine(fullTimeList[x].ToString());
                        }
                    }

                    break;

                case "b": //display a list of part time students
                    {
                        List<Student> partTimeList = StudentList.Students.
                        Where(x => x.GetType() == typeof(ParttimeStudent))
                        .ToList();

                        for (int x = 0; x < partTimeList.Count; x++)
                        {
                            Console.WriteLine(partTimeList[x].ToString());
                        }
                    }
                        
                    break;
                    
                default:
                    Console.WriteLine("There was an error");

                    break;
            }
        }
    }
}
