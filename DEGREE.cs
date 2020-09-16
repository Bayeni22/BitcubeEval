using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_bitcube
{
    public class DEGREE                        /*This refers to the degree the univerity offer*/
    {
        private string degreeName;

        private int duration;
        private List<COURSE> courses = new List<COURSE>();  /*This is the list of courses the degree offers*/
        LECTURER lecturer;                                   // This is link the Lecturer to the degree they will be taking

        public void SetDegreeName(String name)                /*This method is used to assign the degree's name*/
        {
            degreeName = name;
        }

        public string GetDegreeName()                       /*This is a getter method used to retrieve the degree's name*/
        {
            return degreeName;
        }

        public void SetDuration(int Duration)               /*This method is used to assign the degree's duration*/
        {
            duration = Duration;
        }

        public int GetDuration()                            /*This is a getter method used to retrieve the degree's duration*/
        {
            return duration;
        }

        public List<COURSE> GetCourses()                    /*This is a getter method used to retrieve the list of courses the degree offers*/
        {
            return courses;
        }

        public void SetCourses(COURSE course)               /*This method is used to assign the list of courses that are part of a degree*/
        {
            courses.Add(course);
        }

        public void SetLecturer(LECTURER Lecturer)          /*This method is used to assign a lecturer to the degree*/
        {
            lecturer = Lecturer;
        }

        public LECTURER GetLecturer()                       /*This is a getter method used to retrieve the lecturer that is teachs*/
        {
            return lecturer;
        }
    }