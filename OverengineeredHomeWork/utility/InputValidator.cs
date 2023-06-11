
namespace OverengineeredHomeWork.utility
{
    public class InputValidator
    {
        public int InputNumber { get; set; }
        /// <summary>
        /// Validates user input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool ValidateInput(string input)
        {
            int number;
            bool success = int.TryParse(input, out number);

            if (success)
            {
                InputNumber = number;
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
