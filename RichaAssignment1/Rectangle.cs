using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichaAssignment1
{
    public class Rectangle
    {
        private int length;
        private int width;

        // DEFAULT CONSTRUCTOR SET BOTH VALUE BY 1
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
       
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        // GET LENGTH OF RECTANGLE
        public int GetLength()
        {
            return this.length;
        }

        // SET LENGTH OF RECTANGLE
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        // GET WIDTH OF RECTANGLE
        public int GetWidth()
        {
            return this.width;
        }

        // SET WIDTH OF RECTANGLE
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        //GET PARAMETER VALUE OF RECTANGLE
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        //GET AREA OF RECTANGLE
        public int GetArea()
        {
            return  length* width;
        }
    }
}
