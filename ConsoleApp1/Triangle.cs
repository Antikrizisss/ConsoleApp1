
namespace ConsoleApp1
{
    public class Triangle
    {
        //Задача Is this a triangle?
        public static bool IsTriangle(int a, int b, int c)
        {
            if ((a < b + c) & (a > b - c) & (b < a + c) & (b > a - c) & (c < a + b) & (c > a - b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
