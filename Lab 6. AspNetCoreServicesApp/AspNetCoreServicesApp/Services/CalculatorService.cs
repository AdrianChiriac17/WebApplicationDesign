using AspNetCoreServicesApp.Services.Interfaces;

namespace AspNetCoreServicesApp.Services
{
    public class CalculatorService : ICalculatorService
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
