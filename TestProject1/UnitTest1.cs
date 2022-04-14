using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using NUnit.Framework.Internal;
using PracticeApplication.Interface;
using PracticeApplication.Service;

namespace TestProject1;

public class Tests
{
    private ICalculateService _calculateService;
    
    [SetUp]
    public void Setup()
    {
        _calculateService = new CalculateService(new NullLogger<CalculateService>());
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void SumNumbers_inputNumbers_outputNumbers()
    {
        //  
        var a = 10;
        var b = 5;
        var c = 22;
        var expected = a + b + c;
        var list = new int[] {a, b, c};
        
        //
        var result = _calculateService.SumNumbers(list);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
    
}