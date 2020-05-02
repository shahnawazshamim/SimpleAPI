using System.Linq;
using System;
using Microsoft.Extensions.Logging;
using Moq;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        private readonly Mock<ILogger<WeatherForecastController>> _mockRepo;
        private readonly WeatherForecastController _controller;
        public UnitTest1()
        {
            _mockRepo = new Mock<ILogger<WeatherForecastController>>();
            _controller = new WeatherForecastController(_mockRepo.Object);
        }
        
        [Fact]
        public void GetCorrectCount()
        {
            var returnValue = _controller.Get().ToList();
            Assert.Equal(6, returnValue.Count);
        }
    }
}
