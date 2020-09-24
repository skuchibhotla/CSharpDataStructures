using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******************");
            Console.WriteLine("* Student Roster *");
            Console.WriteLine("******************");

            LinkedList<String> _studentList = new LinkedList<string>();

            Console.WriteLine("How can I help you today?\n");
            Console.WriteLine("1. Add a Student to the roster");
            Console.WriteLine("2. Check if a Student is present in the roster");
            Console.WriteLine("3. Delete a Student from roster");
            Console.WriteLine("4. Print all the Student names from roster\n");
            string _inputString = Console.ReadLine();
            int _input = Convert.ToInt32(_inputString);


            switch (_input)
            {
                case 1:
                    Console.WriteLine("Enter the name of the Student: ");
                    string _nameToInsert = Console.ReadLine();
                    _studentList.AddLast(_nameToInsert);
                    break;

                case 2:
                    Console.WriteLine("Enter the name of the Student: ");
                    string _nameToCheck = Console.ReadLine();
                    if (_studentList.Contains(_nameToCheck)) { Console.WriteLine("Yes, {0} is present in the roster.", _nameToCheck); }
                    else { Console.WriteLine("No, {0} is not present in the roster.", _nameToCheck); }
                    break;

                case 3:
                    string _nameAtFirst = _studentList.FirstOrDefault();
                    string _nameAtEnd = _studentList.LastOrDefault();
                    Console.WriteLine("{0} will be removed from the list if you remove from beginning. To remove from last, press '1'.", _nameAtFirst);
                    Console.WriteLine("{0} will be removed from the list if you remove from end. To remove from last, press '2'.", _nameAtEnd);
                    Console.WriteLine("Enter your selection: ");
                    int _selection = Convert.ToInt32(Console.ReadKey());
                    if(_selection == 1) { _studentList.Remove(_studentList.FirstOrDefault()); }
                    else if(_selection == 2) { _studentList.Remove(_studentList.LastOrDefault()); }
                    else { Console.WriteLine("Invalid entry. Please enter as per instructions. Please try again."); }
                    break;

                case 4:
                    if (_studentList.Count == 0) { Console.WriteLine("Roster is empty."); }
                    else 
                    {
                        foreach (string name in _studentList) { Console.WriteLine(name); }
                    }

                    break;

                default:
                    Console.WriteLine("Invalid input received. Please re-enter your choice.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
