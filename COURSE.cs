using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_bitcube
{
    public class COURSE                         /*This refers to the course that the university offers*/

    {
        private string courseName;

        private int Duration;

        private DEGREE degree;                                   /*This refers to the degree the that is part of this course*/

        private List<STUDENT> students = new List<STUDENT>();    /*This is the list of students enrolled in the course*/


        public void SetCourseName(string name)                   /*This method is used to assign the name of the course*/
        {
            courseName = name;

        }

        public string GetCourseName()                           /*This is a getter method used to retrieve the course name*/
        {
            return courseName;
        }

        public void SetDegree(DEGREE Degree)                    /*This method is used to assign a degree to the course*/
        {
            degree = Degree;
        }

        public DEGREE GetDegree()                               /*This is a getter method used to retrieve the degree under that the course is under */
        {
            return degree;
        }

        public void SetDuration(int duration)                   /*This method is used to assigns the duration of the course*/
        {
            Duration = duration;
        }

        public int GetDuration()                                /*This is a getter method used to retrieve the course's duration*/
        {
            return Duration;
        }

        public List<STUDENT> GetStudents() /*This is a getter method used to retrieve the list of students under this course*/
        {
            return students;
        }

        public void SetStudent(STUDENT Student) /*This method is used to assign the list of students that are part of this course*/
        {
            students.Add(Student);
        }


    }
}