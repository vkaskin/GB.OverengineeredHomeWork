using OverengineeredHomeWork.utility;

namespace OverengineeredHomeWork.Core
{
    public class ComparisonProgram : INumberProcessor
    {
        private readonly ReadUsersInput readUsersInput;

        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public ComparisonProgram(ReadUsersInput readUsersInput)
        {
            this.readUsersInput = readUsersInput;
        }
        /// <summary>
        /// Run subprogram
        /// </summary>
        public void Run()
        {
            bool isActive = true;      //flag
            while (isActive)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Введите два числа, чтобы узнать, какое больше, а какое меньше");
                readUsersInput.ReadInput();
                FirstNumber = readUsersInput.InputValidator.InputNumber;    //User's imput after validation

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Принято! А теперь второе число");
                readUsersInput.ReadInput();
                SecondNumber = readUsersInput.InputValidator.InputNumber;    //User's imput after validation

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(ComparisonNumbers(FirstNumber, SecondNumber));

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Чтобы выйти из подпрограммы введите Q или нажмите ENTER чтобы продолжить");

                string input = Console.ReadLine();
                if (input.ToLower() == "q")                //exit from subprogram
                    isActive = false;
            }
        }

        /// <summary>
        /// Prints the result of comparing two numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        private string ComparisonNumbers(int number1, int number2)
        {
            string result;
            if (number1 == number2)
                result = $"Они равны!";
            else if (number1 > number2)
                result = $"число {number1} больше, а число {number2} меньше";
            else
                result = $"число {number2} больше, а число {number1} меньше";

            return result;
        }
    }
}
