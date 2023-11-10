namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        
        public static decimal Add(decimal x, decimal y)
        { 
            return x + y; 
        }

        public static double Add(double x, double y) 
        {
            return (double)x + y; 
        }

        public static string Add(int num1, int num2, bool isMoney)
        {
            var sum = num1 + num2;
            if (isMoney == true && sum > 1)
            {
                return $" {sum} dollars";
            }
            else if (isMoney == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(isMoney== true && sum <1)
            {
                return $"{sum} dollars";
            }
            else 
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            var x = 29;
            var y = 55;
                var answer = Add(x, y);

            var a = 32.0m;
            var b = 45.3m;

            var decimalAnswer = Add(a, b);
            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer); 
     
        }
    }


}
