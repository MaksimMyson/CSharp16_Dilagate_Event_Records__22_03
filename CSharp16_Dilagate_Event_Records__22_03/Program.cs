namespace CSharp16_Dilagate_Event_Records__22_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            Func<string, (int, int, int)> rainbowColorToRGB = color =>
            {
                switch (color.ToLower())
                {
                    case "red":
                        return (255, 0, 0);
                    case "orange":
                        return (255, 165, 0);
                    case "yellow":
                        return (255, 255, 0);
                    case "green":
                        return (0, 128, 0);
                    case "blue":
                        return (0, 0, 255);
                    case "indigo":
                        return (75, 0, 130);
                    case "violet":
                        return (238, 130, 238);
                    default:
                        throw new ArgumentException("Invalid rainbow color");
                }
            };

            
            string color = "blue";
            var rgb = rainbowColorToRGB(color);
            Console.WriteLine($"RGB значення для кольору {color}: ({rgb.Item1}, {rgb.Item2}, {rgb.Item3})");
        }
    }
}
