using System;

namespace PROG7311_ICE2
{

    /*
        Single Responisiblity Principle:
        This chill class only deals with Parttime students

        Liskov Substitution Principle:
        This child class is able to substitue for its parent class
    */

    public class ParttimeStudent : Student, ISubmitAssessment
    {
        
        public ParttimeStudent(string studentId, string name, string surname, string contactNo, string course, bool enrolled) : 
                                    base(studentId, name, surname,contactNo, course, enrolled)
        { 
            //constructor    
        }
    }
}
