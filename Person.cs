using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_bitcube
{
    public class Person                        /*This will be the parent class for the Lecturer and Degree classes*/
    {


        protected string forenames;

        protected string surname;

        protected string emailAddress;

        protected string dOb;   // This is the students's Date of Birth.


        public void Setforenames(string nms) /*This method is used to assign the person's forenames*/
        {
            forenames = nms;

        }

        public string Getforenames() /*This is a getter method used to retrieve the person's forenames*/
        {
            return forenames;
        }

        public void Setsurname(string sur) /*This method is used to assign the person's surname*/
        {
            surname = sur;
        }

        public string Getsurname() /*This is a getter method used to retrieve the person's surname*/
        {
            return surname;
        }

        public string Getfullname() /*This is a getter method used to retrieve the persons names*/
        {
            return forenames + " " + surname;
        }

        public string Getfirstname() /*This method puts the forename string into an array and seperate it using the spaces in between 
                                     So the array will store all the names into respective indexes */
        {
            string[] Forenames = forenames.Split(' ');

            return Forenames[0];
        }

        public void Setemail(string email) /*This method is used to assign the persons email*/
        {
            emailAddress = email;
        }

        public string Getemail() /*This is a getter method used to retrieve the person's email address*/
        {
            return emailAddress;
        }

        public void Setdate(string dt) /*This method is used to assign the persons date of birth*/
        {

            dOb = dt;
        }

        public string Getdate() /*This is a getter method used to retrieve the person's date of birth*/
        {
            return dOb;

        }


    }
}