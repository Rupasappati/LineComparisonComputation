using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LineComparison
{

    public class LineComparison
    {
        double LineOfLength;
        double lengthLine1;
        double lengthLine2;

        public void lineLengthComparison()
        {
            //Input of Cordinates
            Console.Write("Enter the Cordinate of x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Cordinate of x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Cordinate of x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Cordinate of x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the Cordinate of y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Cordinate of y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Cordinate of y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Cordinate of y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());

            //Length of the lines
            lengthLine1 = Math.Pow(x2 - x1, 2)+Math.Pow(y2 - y1, 2);
            LineOfLength = Math.Sqrt(lengthLine1);
            Console.WriteLine("Length of the line 1 is {0}", LineOfLength);

            lengthLine2 = Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2);
            LineOfLength = Math.Sqrt(lengthLine2);
            Console.WriteLine("Length of the line 2 is {0}", LineOfLength);
        }
        public void EqualityOfLines()
        {
            if (lengthLine1 == lengthLine2)
            {
                Console.WriteLine("Two lines are Equal");
            }
            else
            {
                Console.WriteLine("Two lines are not Equal");
            }
        }

    }

}