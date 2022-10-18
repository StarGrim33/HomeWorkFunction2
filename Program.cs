namespace HomeworkFunction2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 0;
            int value = 0;
            int position = 0;
            bool isProgrammOn = true;

            while (isProgrammOn)
            {
                const string CommandHealthBar = "Healthbar";
                const string CommandManaBar = "Manabar";
                const string CommandExit = "Exit";

                ShowMenu();
                string userMenuNavigate = Console.ReadLine();

                switch (userMenuNavigate)
                {
                    case CommandHealthBar:
                        DrawBar(value, maxValue, ConsoleColor.Red, position);
                        break;
                    case CommandManaBar:
                        DrawBar(value, maxValue, ConsoleColor.Blue, position);
                        break;
                    case CommandExit:
                        isProgrammOn = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда попробуйте еще раз");
                        break;
                }

            }

        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position)
        {
            Console.WriteLine("Введите уровень здоровья/маны: ");
            maxValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите какой % нужно закрасить: ");
            value = Convert.ToInt32(Console.ReadLine());

            value = (value * maxValue) / 100;

            Console.WriteLine("Введите позицию: ");
            position = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += ' ';
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += '#';
            }

            Console.Write(bar + ']');
        }

        static void ShowMenu()
        {
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Напишите какой элемент Вы хотите вывести на экран ? \n #-Healthbar \n #-Manabar \n #-Exit");
        }

    }
}