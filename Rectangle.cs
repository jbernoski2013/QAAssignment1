using System;
using System.Collections.Generic;
using System.Text;

namespace JBQA1
{
    /*Julia Bernoski
     * Feb 9th 2018
     * Rectangle Class
     */

    public class Rectangle
    {
        //Default values
        private int length = 1;
        private int width = 1; 
       
        //get and set for length
        public int getLength(int length)
        {
            if (length == 0)
            {
                length = 1;
            }

            return length;
        }

        public int setLength(int length)
        {
            if (length < 1)
            {
                length = 1;
            }
            return length;
        }


        //get and set for width
        public int getWidth(int width)
        {
            if (width == 0)
            {
                width = 1;
            }
            return width;
        }

        public int setWidth(int width)
        {
            if (width < 1)
            {
                width = 1;
            }
            return width;
        }

       // get perimeter
        public int getPerimeter(int length, int width)
        {
            return 2 * (length + width);
        }

        //get area
        public int getArea(int length, int width)
        {
            return width * length;
        }

    }
}

