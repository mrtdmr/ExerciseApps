using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UnitTestingApp.Controllers;
using Xunit;

namespace web_api_tests
{
    public class ShoppingCartControllerTest
    {
        ShoppingCartController _controller;
        IShoppingCartService _service;
        public ShoppingCartControllerTest()
        {
            _service = new ShoppingCartServiceFake();
            _controller = new ShoppingCartController(_service);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            //Act
            var okResult = _controller.Get();
            //Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.Get().Result as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<ShoppingItem>>(okResult.Value);
            Assert.Equal(5, items.Count);
        }
    }
}
