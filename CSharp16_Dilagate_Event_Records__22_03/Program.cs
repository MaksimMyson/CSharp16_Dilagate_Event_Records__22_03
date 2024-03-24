namespace CSharp16_Dilagate_Event_Records__22_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<DateTime, bool> isProgrammersDay = date => date.DayOfYear == 256;

           
            DateTime testDate1 = new DateTime(2024, 9, 12); 
            DateTime testDate2 = new DateTime(2024, 9, 13); 

            Console.WriteLine($"Is {testDate1:yyyy-MM-dd} Programmers' Day? {isProgrammersDay(testDate1)}");
            Console.WriteLine($"Is {testDate2:yyyy-MM-dd} Programmers' Day? {isProgrammersDay(testDate2)}");
        }
    }
}
