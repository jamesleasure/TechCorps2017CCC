using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the 'Student Grouper 1.0'\n");
            System.Console.WriteLine("This application takes in a list of students and creates groups of them based on the group size specified.\n\n");

            List<string> students = getStudents();

            System.Console.Write("What should the size of the groups be? : ");
            int groupSize = int.Parse(System.Console.ReadLine());

            printGroups(groupSize, students);

            System.Console.ReadLine();
        }

        static List<string> getStudents()
        {
            List<string> students = new List<string>();

            bool keepAddingStudents = true;

            while (keepAddingStudents)
            {
                System.Console.Write("Please Enter Student Name (q to quit) : ");
                String student = System.Console.ReadLine();
                students.Add(student);

                // If the user types "q", break the loop
                if (student == "q")
                {
                    keepAddingStudents = false;
                    break;
                }

                System.Console.WriteLine("Current number of students: " + students.Count);
            }

            return students;
        }

        static void printGroups(int groupSize, List<string> students)
        {
            int currentGroupSize = 0;
            int currentGroupNumber = 0;

            for (int i = 0; i <= students.Count; i++)
            {
                String student = students[i];
                // If we are starting a new group, print out the group header
                if (currentGroupSize == 0)
                {
                    System.Console.WriteLine("Group " + (currentGroupNumber));

                }

                // Print student name out
                System.Console.WriteLine("\t" + student);
                currentGroupSize++;

                // If our current groupSize is equal to the group size we should have set, reset the current group size
                if (currentGroupSize == groupSize)
                {
                    currentGroupSize = 0;
                    currentGroupNumber++;
                }
            }
        }
    }
}