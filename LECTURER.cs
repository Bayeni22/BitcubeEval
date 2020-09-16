using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_bitcube
{
    public class LECTURER : Person            /*Lecturer inherits from person class because of the commonality thats exists between the
                                                commonality that exists between the two classes therefore lecturer*/
    {
        private List<DEGREE> degrees = new List<DEGREE>(); /*This is the list of degrees the Lecturer is assigned to*/

        public List<DEGREE> GetDegrees()
        {
            return degrees;

        }

        public void SetDegrees(DEGREE Degree)                /*This method is used to assign a degree to the Lecturer*/
        {
            degrees.Add(Degree);
        }
    }

}