using OverengineeredHomeWork.utility;

namespace OverengineeredHomeWork.Core
{
    public class CheakEvenNumberProgram : INumberProcessor
    {
        private readonly ReadUsersInput readUsersInput;
        public int Number { get; set; }

        public CheakEvenNumberProgram(ReadUsersInput readUsersInput)
        {
            this.readUsersInput = readUsersInput;
        }
        /// <summary>
        /// Run subprogram
        /// </summary>
        public void Run()
        {
            bool isActive = true;           //flag
            while (isActive)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Введите число, для проверки на четность");
                readUsersInput.ReadInput();
                Number = readUsersInput.InputValidator.InputNumber;     //User's imput after validation

                EvenNumberCheaker(Number);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Чтобы выйти из подпрограммы введите Q или нажмите ENTER чтобы продолжить");

                string input = Console.ReadLine();
                if (input.ToLower() == "q")              //exit from subprogram
                    isActive = false;
            }
        }

        /// <summary>
        /// Prints the result of the parity check to the console
        /// </summary>
        /// <param name="number"></param>
        private void EvenNumberCheaker(int number)
        {
            int numberForCheak = number;
            if (number % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Число {numberForCheak} четное!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Число {numberForCheak} нечетное");
            }
        }
    }
}
