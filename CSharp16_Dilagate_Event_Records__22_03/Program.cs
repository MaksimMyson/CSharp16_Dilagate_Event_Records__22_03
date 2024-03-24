namespace CSharp16_Dilagate_Event_Records__22_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Func<int[], int> findMax = arr => arr.Max();

            
            int[] numbers = { 3, 7, 2, 9, 1, 5 };

            Console.WriteLine($"Максимум у масиві: {findMax(numbers)}");
        }
    }
}
