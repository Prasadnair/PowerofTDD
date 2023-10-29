using Microsoft.Extensions.Logging;

namespace TDDApproach
{
    public class Calculator
    {
        private readonly ILogger _logger;
        public Calculator(ILogger loggger)
        {
            _logger = loggger;

        }

        public int Add(int a, int b)
        {
            _logger.LogInformation($"Adding {a} and {b}");
            return a + b;
        }

    }
}