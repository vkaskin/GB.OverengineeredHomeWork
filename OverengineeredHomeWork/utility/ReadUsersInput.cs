
namespace OverengineeredHomeWork.utility
{
    public class ReadUsersInput
    {
        public InputValidator InputValidator { get; set; }
        public ReadUsersInput(InputValidator inputValidator)
        {
            this.InputValidator = inputValidator;
        }

        /// <summary>
        /// Accepts user input
        /// </summary>
        public void ReadInput()
        {
            string input;
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Введите число");

                input = Console.ReadLine();

                bool isInputValid = InputValidator.ValidateInput(input);         //validation
                if (!isInputValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка! Введите целочисленное число");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
