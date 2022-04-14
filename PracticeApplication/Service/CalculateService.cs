using Microsoft.Extensions.Logging;
using PracticeApplication.Interface;

namespace PracticeApplication.Service
{
    public class CalculateService : ICalculateService
    {
        private ILogger<CalculateService> _logger;

        public CalculateService(ILogger<CalculateService> logger)
        {
            _logger = logger;
        }

        public int SumNumbers(int[] intList)
        {
            var sum = 0;
            for (int i = 0; i < intList.Length; i++)
            {
                var num = intList[i];
                sum += num;
            }

            return sum;
        }
    }
}