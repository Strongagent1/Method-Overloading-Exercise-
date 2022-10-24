using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MethodOverloading
{
    public class Program
    {
        static int Add(int x, int y)
        { return x + y; } 
           

        static decimal Add(decimal x, decimal y)
        { return x + y; }

            
        static string Add(int x, int y, bool z)
        {
            if (z && (x + y) != 1)
            {
                return $"{x + y} dollars";
            }
            else if (z && (y + x) == 1)
            {
                return $"{x + y} dollar";

            }else
            {
                return $"{x+y}";
            }


        }        

        static void Main(string[] args)
        {
            var answer = Add(0, 1, true);
            Console.WriteLine(answer);
        }
    }
}
