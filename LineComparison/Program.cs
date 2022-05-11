// See https://aka.ms/new-console-template for more information

namespace LineComparison
{
    class Program
    {
    static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");   
            LineComparison obj = new LineComparison();
            
            //Line line comparison
            obj.lineLengthComparison();
            //checking equality of lines
            obj.EqualityOfLines();
            //comparison of two lines
            obj.CompareTwoLines();
        }

    }
}


