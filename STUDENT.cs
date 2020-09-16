using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_bitcube
{

    public class STUDENT : Person              /*Student inherits all the public and protected members of perso class*/
    {
        private DEGREE degree;                 /*This is the refers to the degree the student is enrolled in*/

        public void SetDegree(DEGREE Degree)   /*This method is used to assign a degree to the student*/
        {
            degree = Degree;

        }

        public DEGREE GetDegree()              /*This is a getter method used to retrieve the degree the student is enrolled in*/
        {
            return degree;
        }
    }
}