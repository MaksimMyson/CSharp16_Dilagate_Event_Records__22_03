namespace CSharp16_Dilagate_Event_Records__22_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<int, int> square = delegate (int number)
            {
                return number * number;
            };

            
            int num = 5;

            Console.WriteLine($"Square of {num}: {square(num)}");
        }
    }
}
