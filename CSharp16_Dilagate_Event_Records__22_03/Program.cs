namespace CSharp16_Dilagate_Event_Records__22_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
                
            
            Console.Write("Введіть слово для перевірки: ");
            string targetWord = Console.ReadLine();

            
            Func<string, string, bool> checkForWord = (text, word) => text.ToLower().Contains(word.ToLower());

           
            Console.WriteLine("Введіть текст для перевірки:");
            string testText = Console.ReadLine(); 
            bool containsWord = checkForWord(testText, targetWord); 

          
            if (containsWord)
            {
                Console.WriteLine($"Текст містить слово '{targetWord}'.");
            }
            else
            {
                Console.WriteLine($"Текст не містить слово '{targetWord}'.");
            }
        }
    }
}
