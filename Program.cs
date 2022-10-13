namespace HomeworkFunction2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 10;
            int value = 0;
            int position = 0;
            bool isProgrammOn = true;

            while (isProgrammOn)
            {
                ShowMenu();
                string userMenuNavigate = Console.ReadLine();
                
                switch(userMenuNavigate)
                {
                    case "1":
                        DrawBar(value, maxValue, ConsoleColor.Red, position);
                        break;
                    case "2":
                        DrawBar(value, maxValue, ConsoleColor.Blue, position);
                        break;
                    case "3":
                        isProgrammOn = false;
                        break;
                }

            }

        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position)
        {
            Console.WriteLine("Введите какой % нужно закрасить: ");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите позицию: ");
            position = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            
            for (int i = 0; i < value; i++)
            {
                bar += ' ';
            }

            Console.SetCursorPosition(0,position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for(int i = value; i < maxValue; i++)
            {
                bar += '#';
            }

            Console.Write(bar + ']');
        }
        
        static void ShowMenu()
        {
            Console.SetCursorPosition(10, 0);
            Console.WriteLine("Здравствуйте! Какой элемент Вы хотите вывести на экран ? \n 1 - Healthbar \n 2 - Manabar \n 3 - Exit");
        }

    }
}