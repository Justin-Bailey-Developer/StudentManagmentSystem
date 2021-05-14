using System;

namespace PROG7311_ICE2
{

/*
    --Open Closed Principle--
    This Student class can be extended from to make 
    the Fulltime and Parttime Student classes - without 
    needing to modify this parent class because the methods can be overwrriten

    --Liskov Substituion Principle--
    All attributes and methods in this abstract/parent class are relevant
    to both types of students (Full time and part time students), so the 
    children classes will not get implementaion exceptions 

    --Dependency Inversion Principle--
    This abstract class 
*/

    public abstract class Student : ISubmitAssessment
    {

        protected string StudentId { get; set; }     
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected string ContactNo { get; set; }
        protected string Course { get; set; }
        protected bool Enrolled { get; set; }

        public Student(string studentId, string name, string surname, string contactNo, string course, bool enrolled)
        {
            this.StudentId = studentId;
            this.Name = name;
            this.Surname = surname;
            this.ContactNo = contactNo;
            this.Course= course;
            this. Enrolled = enrolled;
        }

        // public void submitAssessment(){
        //     //submit assessment
        // }

        public void SubmitTest(){
            //submit test
        }

        public void SubmitExam(){
            //submit exam
        }

        public void SubmitAssignment(){
            //submit assignment
        }
                
        public override string ToString()
        {
            string output = StudentId+",\t"+ Name + " " + Surname + ",\t" + Course;

            return output;
        }
    }
}
