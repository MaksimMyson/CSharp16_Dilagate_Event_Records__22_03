namespace CSharp16_Dilagate_Event_Records__22_03
{

    class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть числа, розділені пробілами:");
            string input = Console.ReadLine();
            string[] numbersAsString = input.Split(' ');
            int[] numbers = Array.ConvertAll(numbersAsString, int.Parse);

           
            Console.WriteLine("Масив:");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            
            Func<int[], int> countPositiveNumbers = arr => Array.FindAll(arr, x => x > 0).Length;
           

            
            int count = countPositiveNumbers(numbers);
            Console.WriteLine($"Кількість позитивних чисел у масиві: {count}");

        
        }
    }
}

