using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Moq;
using System.Net;

namespace BillServiceWebRole.Tests
{
    [TestClass]
    public class BillServiceWebRoleUnitTest
    {
        [TestMethod]
        public void GetBill_NormalCall_ValidResponse()
        {
            //Arrange
            BillService service = new BillService();

            //Act
            string response = service.GetBill();
            response = response.Trim();
            bool expected = false;
            if ((response.StartsWith("{") && response.EndsWith("}")) || (response.StartsWith("[") && response.EndsWith("]")))
            {
                expected = true;
            }

            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void GetBill_NormalCall_ExceptionResponse()
        {
            //Arrange
            WebClient webClient = new WebClient();
            webClient.BaseAddress = "http://safe-plains-5453.herokuapp.co/";
            var mock = new Mock<BillService>(webClient) { CallBase = true };
            BillService billService = mock.Object;
           
            //Act
            string response = billService.GetBill();

            //Assert
            bool expected = false;
            if (response.Contains("Exception"))
            {
                expected = true;
            }

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void GetBill_NormalCall_EmptyResponse()
        {
            //Arrange
            var mock = new Mock<IBillService>();
            mock.Setup(mockService => mockService.GetBill()).Returns(string.Empty);
            IBillService billService = mock.Object;

            //Act
            string response = billService.GetBill();

            //Assert
            bool expected = false;
            if (string.IsNullOrEmpty(response))
            {
                expected = true;
            }

            Assert.IsTrue(expected);
        }
    }
}
