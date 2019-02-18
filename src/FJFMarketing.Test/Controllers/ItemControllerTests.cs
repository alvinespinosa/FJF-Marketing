using FJFMarketing.Controllers;
using FJFMarketing.Models.Entities;
using FJFMarketing.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FJFMarketing.Test.Controllers
{
    [TestClass]
    public class ItemControllerTests
    {
        [TestMethod]
        public void CreateItem_Success()
        {
            // Arrange
            var mockRepository = new MockRepository(MockBehavior.Strict);

            var mockItemService = mockRepository.Create<IItemService>();

            mockItemService.Setup(_ => _.AddItem(It.IsAny<Item>()));

            var controller = CreateItemController(mockRepository, mockItemService);

            var item = new Item { Name = "test" };

            // Act
            dynamic result = controller.Create(item);
            var actual = result.Value;

            // Assert
            mockRepository.VerifyAll();
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual(item.Name, actual.Name);
        }

        [TestMethod]
        public void CreateItem_ItemNull_ReturnBadRequest()
        {
            // Arrange
            var mockRepository = new MockRepository(MockBehavior.Strict);

            var mockItemService = mockRepository.Create<IItemService>();

            var controller = CreateItemController(mockRepository, mockItemService);

            // Act
            var result = controller.Create(null);

            // Assert
            Assert.AreEqual(typeof(BadRequestResult), result.GetType());
        }

        private ItemController CreateItemController(MockRepository mockRepo,
            Mock<IItemService> mockItemService = null)
        {
            var controller = new ItemController(mockItemService.Object);

            return controller;
        }
    }
}
