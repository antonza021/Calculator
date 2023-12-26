using FabricMethod.Exeptions;

namespace FabricMethod
{
    class Program
    {
        static void Main()
        {
            StackCalculator calculator = new StackCalculator();

            try
            {
                double result = calculator.Calculate("10 30 10 * + 10 +");
                Console.WriteLine($"Result: {result}");
            }
            catch (CalculatorException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}