namespace CSharp16_Dilagate_Event_Records__22_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            Func<int[], int> countMultiplesOfSeven = arr => Array.FindAll(arr, x => x % 7 == 0).Length;

           
            int[] testArray = { 7, 14, 21, 28, 35, 42, 8, 10, 49 }; 
            int count = countMultiplesOfSeven(testArray); 
            Console.WriteLine($"Кількість чисел у масиві, кратних семи: {count}");
        }
    }
}
