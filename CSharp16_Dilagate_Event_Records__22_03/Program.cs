namespace CSharp16_Dilagate_Event_Records__22_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            Func<int[], int[]> uniqueNegativeNumbers = arr => arr.Where(x => x < 0).Distinct().ToArray();

            
            int[] testArray = { -2, 5, -2, 3, -5, 7, -5 };
            int[] uniqueNegatives = uniqueNegativeNumbers(testArray); 

            
            Console.WriteLine("Унікальні негативні числа у масиві:");
            foreach (var num in uniqueNegatives)
            {
                Console.WriteLine(num);
            }
        }
    }
}
