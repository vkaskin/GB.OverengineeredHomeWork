using OverengineeredHomeWork.utility;

namespace OverengineeredHomeWork.Core
{
    public class MaximumProgram : INumberProcessor
    {
        private readonly ReadUsersInput readUsersInput;

        public MaximumProgram(ReadUsersInput readUsersInput)
        {
            this.readUsersInput = readUsersInput;
        }
        /// <summary>
        /// Run subprogram
        /// </summary>
        public void Run()
        {
            bool isActive = true;        //flag
            while (isActive)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Введите три числа, чтобы получить максимальное из них");
                readUsersInput.ReadInput();

                int[] array = new int[3];
                array[0] = readUsersInput.InputValidator.InputNumber;             //User's imput after validation

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Принято! А теперь второе число");
                readUsersInput.ReadInput();
                array[1] = readUsersInput.InputValidator.InputNumber;             //User's imput after validation

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Принято! А теперь третье число");
                readUsersInput.ReadInput();
                array[2] = readUsersInput.InputValidator.InputNumber;             //User's imput after validation

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Максимальное из чисел: ");
                Console.WriteLine(Maximum(array));

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Чтобы выйти из подпрограммы введите Q или нажмите ENTER чтобы продолжить");


                string input = Console.ReadLine();
                if (input.ToLower() == "q")                     //exit from subprogram
                    isActive = false;
            }
        }

        /// <summary>
        /// Prints the maximum of three numbers
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private int Maximum(int[] array)
        {
            int max = int.MinValue;
            foreach (var number in array)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }


    }
}
