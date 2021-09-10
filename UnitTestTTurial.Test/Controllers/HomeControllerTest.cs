using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestTT.Controllers;
using UnitTestTT.Model;
using Xunit;

namespace UnitTestTTurial.Test.Controllers
{
    public class HomeControllerTest 
    {
        [Fact]
        public void Index()
        {
            var homecontroller = new HomeController();

            // Json dönerse ona göre düzenleme yapılır
            var result = homecontroller.Index() as ViewResult;

            Assert.NotNull(result);
            // Tip Karşılaştırması
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Contact()
        {
            var homecontroller = new HomeController();

            var result = homecontroller.Contact() as ViewResult;
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        // Form Kontrolü
        [Fact]
        public void ContactPost()
        {
            var homecontroller = new HomeController();

            var model = new ContactVM()
            {
                Email = "a.b@c.d",
                Title = "message",
                Message = "buralar hep sorun"

            };
            var result = homecontroller.Contact(model) as ViewResult;

            Assert.NotNull(result);
        }

        //parametreli - Test Explorerde Ayrı bir ağaç oluştu
        [Theory]
        [InlineData("", "", "")]
        [InlineData("", "hello", "world")]
        [InlineData(null, null, null)]
        public void ContactPost2(string email, string title, string message)
        {
            var homecontroller = new HomeController();

            var model = new ContactVM()
            {
                Email = email,
                Title = title,
                Message = message

            };
            var result = homecontroller.Contact(model) as ViewResult;

            Assert.NotNull(result);
        }
    }
}
