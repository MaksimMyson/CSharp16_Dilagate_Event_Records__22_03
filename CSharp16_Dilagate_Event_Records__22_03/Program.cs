namespace CSharp16_Dilagate_Event_Records__22_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<int, bool> isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            
            int num1 = 10;
            int num2 = 7;

            Console.WriteLine($"{num1} is {(isEven(num1) ? "even" : "odd")}");
            Console.WriteLine($"{num2} is {(isEven(num2) ? "even" : "odd")}");
        }
    }
}
