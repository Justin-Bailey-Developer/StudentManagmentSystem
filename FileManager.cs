using System;
using System.Collections.Generic;
using System.IO;

namespace PROG7311_ICE2
{

    /*
        Dependency Inversion Principle:
        The data source(text file) is read and writen from 
        in this class so that only this class would need to be modified
    */

    public static class FileManager
    {

        private static StreamReader file = new StreamReader(@"students.txt");

        public static List<Student> Students;

        public static List<Student> ReadFile()
        {

            Students = new List<Student>();

            string line = "";
            string id, name, surname, cellNo, course;
            bool enrolled;
            int groupNo;

            System.IO.StreamReader file = new System.IO.StreamReader(@"students.txt");
            
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                string[] split = line.Split(',');

                id = split[0].Trim();
                name = split[1].Trim();
                surname = split[2].Trim();
                cellNo = split[3].Trim();
                course = split[4].Trim();
                enrolled = Convert.ToBoolean(split[5]);

                if (split.Length == 6)
                {
                    //part time student
                    Students.Add(new ParttimeStudent(id, name, surname, cellNo, course, enrolled));
                }
                else
                {
                    //full time student
                    groupNo = Convert.ToInt32(split[6]);
                    Students.Add(new FulltimeStudent(id, name, surname, cellNo, course, enrolled, groupNo));
                }
            }

            file.Close();

            return Students;
        }

        public static void WriteFile(Student student)
        {
 
        }

    }
}