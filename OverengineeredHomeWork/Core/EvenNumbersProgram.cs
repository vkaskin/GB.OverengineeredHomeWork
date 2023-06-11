using OverengineeredHomeWork.utility;
using System.Text;

namespace OverengineeredHomeWork.Core
{
    public class EvenNumbersProgram : INumberProcessor
    {
        private readonly ReadUsersInput readUsersInput;
        public int Number { get; set; }

        public EvenNumbersProgram(ReadUsersInput readUsersInput)
        {
            this.readUsersInput = readUsersInput;
        }

        /// <summary>
        /// Run subprogram
        /// </summary>
        public void Run()
        {
            bool isActive = true;       //flag
            while (isActive)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Введите число, чтобы получить все четные от 1 до N");
                readUsersInput.ReadInput();
                Number = readUsersInput.InputValidator.InputNumber;     //User's imput after validation

                if (Number > 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"Все четные числа от 1 до {Number}: ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(PrintEvenNumbers(Number));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Между цифрой 1 и цифрой {Number} нет четных чисел");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Чтобы выйти из подпрограммы введите Q или нажмите ENTER чтобы продолжить");

                string input = Console.ReadLine();
                if (input.ToLower() == "q")            //exit from subprogram
                    isActive = false;
            }
        }

        /// <summary>
        /// Prints even numbers from 1 to the number entered by the user
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string PrintEvenNumbers(int number)
        {
            int inputNumber;
            StringBuilder result = new StringBuilder();
            for (int i = 2; i <= number; i++)
            {
                if (i % 2 == 0)
                    result.Append(i + ", "); 
            }
            result.Remove(result.Length - 2, 2);   //Remove from result ", " alter the last number
            return result.ToString();
                 
        }
    }
}
