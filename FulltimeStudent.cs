

namespace PROG7311_ICE2
{

    /*
        Single Responisiblity Principle:
        This chill class only deals with Fulltime students

        Liskov Substitution Principle:
        This child class is able to substitue for its parent class

        Open-Close Principle:
        This child class extends the parent class without needing to modify the parent class,
        because this child class overrides its parent class
    */

    public class FulltimeStudent : Student, ISubmitAssessment
    {
              
        public int GroupNo { get; set; }

        public FulltimeStudent(string studentId, string name, string surname, string contactNo, string course, bool enrolled, int groupNo)
                                        : base(studentId, name, surname, contactNo, course, enrolled){ 
            
            GroupNo = groupNo;
        }

        //the ToString method has been overrided to add the group number, which is only applicable to full time students
        public override string ToString()
        {
            return base.ToString() + ", Group " + GroupNo;
        }
    }
}