namespace CSharp16_Dilagate_Event_Records__22_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<int, int> cube = x => x * x * x;

           
            int num = 3;

            Console.WriteLine($"Cube of {num}: {cube(num)}");
        }
    }
}
