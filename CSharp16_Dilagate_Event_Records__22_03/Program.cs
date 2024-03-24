namespace CSharp16_Dilagate_Event_Records__22_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            Func<int[], int[]> findOddNumbers = arr => arr.Where(num => num % 2 != 0).ToArray();

            
            int[] numbers = { 3, 7, 2, 9, 1, 5 };

            int[] oddNumbers = findOddNumbers(numbers);

            Console.WriteLine("Непарні числа у масиві:");

            foreach (int num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
