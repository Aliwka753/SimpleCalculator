class Program
{
    static void Main(string[] args)
    {
        //Создаем переменные для выполнения операций.
        double firsNumber, secondNumber;
        string action;

        //Создаем цикл while,чтобы программа не закрылась при завершении операции.
        while (true)
        {
            Console.Clear();

            //Просим пользователя ввести число 1 и число 2 в блоке try/catch.
            try
            {
                Console.WriteLine("Введите первое число: ");
                firsNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число: ");
                secondNumber = double.Parse(Console.ReadLine());
            }
            //Если пользователь ввел не числовые значения, выводим ошибку на экран.
            catch(Exception)
            {
                Console.WriteLine("Ошибка, введите число.");
                Console.ReadLine();
                continue;
            }
            
            Console.WriteLine("Выберите операцию: '+', '-', '*', '/'");
            action = Console.ReadLine();

            // Выполнение операций в блоке switch.
            switch(action)
            {
                case "+":
                    Console.WriteLine(firsNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firsNumber - secondNumber);
                    break;
                case "*":
                    Console.WriteLine(firsNumber * secondNumber);
                    break;
                case "/":
                    //т.к на ноль делить нельзя, создаем ветку if чтобы избежать ошибок выполнения.
                    if(firsNumber == 0 || secondNumber == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firsNumber / secondNumber);
                    break; 

                default:
                    Console.WriteLine("Неизвестное действие.");
                    break;
            }
            Console.ReadLine();
            
        }
    }
}