
namespace ConsoleApp1
{
    public class Triangle
    {
        //Задача Is this a triangle?
        public static bool IsTriangle(int a, int b, int c)
        {
            // Вместо побитовой & лучше использовать &&, т.к. & будет проверять условное выражение
            // даже если какая-то часть уже вернула false. && перестанет производить проверку после первого false
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
