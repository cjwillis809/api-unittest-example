using System.Threading.Tasks;
using RandomService.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace RandomServiceTests
{
    public class ValuesTest
    {
        ValuesController _controller;
        public ValuesTest()
        {
            _controller = new ValuesController();
        }
        [Fact]
        public void Get_ReturnsOkResult()
        {
            var result = _controller.Get();
            Assert.IsType<OkObjectResult>(result.Result);
        }

        [Fact]
        public void Get_ReturnsAllValues()
        {
            var okResult = _controller.Get().Result as OkObjectResult;

            var items = Assert.IsType<string[]>(okResult.Value);
            Assert.Equal(2, items.Count());
        }
    }
}