namespace CSharp16_Dilagate_Event_Records__22_03
{
    class Backpack
    {
        private string color;
        private string brand;
        private string material;
        private double weight;
        private double volume;
        private List<Item> contents;

        public event EventHandler<ItemEventArgs> ItemAdded;

        public Backpack()
        {
            Console.WriteLine("Введіть характеристики рюкзака:");
            Console.Write("Колір: ");
            color = Console.ReadLine();

            Console.Write("Марка і виробник: ");
            brand = Console.ReadLine();

            Console.Write("Тканина: ");
            material = Console.ReadLine();

            Console.Write("Вага (кг): ");
            if (!double.TryParse(Console.ReadLine(), out weight))
            {
                throw new ArgumentException("Некоректне значення для ваги");
            }

            Console.Write("Об'єм (л): ");
            if (!double.TryParse(Console.ReadLine(), out volume))
            {
                throw new ArgumentException("Некоректне значення для об'єму");
            }

            contents = new List<Item>();
        }

        public void AddItem(Item item)
        {
            if (volume - item.Volume < 0)
            {
                throw new InvalidOperationException("Перевищено обсяг рюкзака");
            }

            contents.Add(item);
            volume -= item.Volume;

            OnItemAdded(item);
        }

        protected virtual void OnItemAdded(Item item)
        {
            ItemAdded?.Invoke(this, new ItemEventArgs(item));
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Volume { get; set; }

        public Item(string name, double volume)
        {
            Name = name;
            Volume = volume;
        }
    }

    class ItemEventArgs : EventArgs
    {
        public Item AddedItem { get; }

        public ItemEventArgs(Item item)
        {
            AddedItem = item;
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            try
            {
                Backpack backpack = new Backpack();

                backpack.ItemAdded += (sender, e) =>
                {
                    Console.WriteLine($"До рюкзака було додано: {e.AddedItem.Name}");
                };

                Console.WriteLine("\nДодайте предмети в рюкзак:");
                while (true)
                {
                    Console.Write("Назва предмета: ");
                    string name = Console.ReadLine();

                    Console.Write("Об'єм (л): ");
                    if (!double.TryParse(Console.ReadLine(), out double volume))
                    {
                        Console.WriteLine("Некоректне значення для об'єму. Спробуйте знову.");
                        continue;
                    }

                    backpack.AddItem(new Item(name, volume));

                    Console.Write("Продовжити додавання? (так/ні): ");
                    string continueInput = Console.ReadLine().ToLower();
                    if (continueInput != "так")
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
