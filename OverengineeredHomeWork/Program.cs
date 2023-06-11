using OverengineeredHomeWork.Core;
using OverengineeredHomeWork.utility;

namespace OverengineeredHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strategies. In this case I don't use DI-container (KISS)
            INumberProcessor programComparison = new ComparisonProgram(new ReadUsersInput(new InputValidator()));
            INumberProcessor programCheakEvenNumber = new CheakEvenNumberProgram(new ReadUsersInput(new InputValidator()));
            INumberProcessor programEvenNumbers = new EvenNumbersProgram(new ReadUsersInput(new InputValidator()));
            INumberProcessor programMaximum = new MaximumProgram(new ReadUsersInput(new InputValidator()));

            ProgramSwitcher switcher = new ProgramSwitcher(programComparison);    //context
            InputValidator inputValidator = new();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"На выбор представлены 4 типа программ работы с числами");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"1 - Программа принимает ДВА числа и выводит какое из них больше, а какое меньше");
                Console.WriteLine($"2 - Программа принимает ТРИ числа и выводит максимальное из них");
                Console.WriteLine($"3 - Программа принимает ОДНО число и проверяет его на четность");
                Console.WriteLine($"4 - Программа принимает ОДНО число и выводит все четные числа от 1 до N");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Введите число от 1 до 4 для выбора программы. По-умолчанию запускается программа 1 или предыдущая");

                var input = Console.ReadLine();
                inputValidator.ValidateInput(input);

                int number = inputValidator.InputNumber;           //validation

                switch (number)
                {
                    case 1: switcher.SetProgram(programComparison); break;

                    case 2: switcher.SetProgram(programMaximum); break;

                    case 3: switcher.SetProgram(programCheakEvenNumber); break;

                    case 4: switcher.SetProgram(programEvenNumbers); break;

                }

                switcher.RunProgramm();
                Console.Clear();
            }
            

            
        }
    }
}