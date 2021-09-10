using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestTT.Controllers;
using UnitTestTT.Data;
using UnitTestTT.Repository.Interfaces;
using Xunit;

namespace UnitTestTTurial.Test.Controllers
{
    public class WebUserControllerTest
    {
        private readonly Mock<IWebUserRepository> _mockwebUserRepository;

        public WebUserControllerTest()
        {
            _mockwebUserRepository = new Mock<IWebUserRepository>();
        }

        [Fact]
        public void Index()
        {
            // Db ile yapınca Rpository ile çalıştığımızdan onunda ayağaa kalkacak şekilde işlem yapmamız gerekecekti.Mow ile bunu yapmamıza gerkek kalmıyor.
            // Yaptığımızda ise burada oluşturduğumuz repository ile controller içindeki repositoryi eşleştiremiyor. Çünkü bu ayarları stratup.cs içinde yaptık.
            // Çünkü Class ayağa kalmak için interface gerek duyuyor. Böylece interfaceini bağlama işlemleri yapmamız lazımdı.
            // Mock ise istediğim şekilde kullanabileceğim bir yapı sunuyor.

            var controller = new WebUserController(_mockwebUserRepository.Object);

            var result = controller.Index() as ViewResult;

            Assert.NotNull(result);
        }

        [Fact]
        public void Index2()
        {
            List<WebUser> webUsers = new List<WebUser>();

            WebUser webUser = new WebUser()
            {
                Name = "Hasan",
                Surname = "Dogan"
            };

            WebUser webUser1 = new WebUser()
            {
                Name = "Hasan",
                Surname = "Dogan"
            };

            webUsers.Add(webUser1);
            webUsers.Add(webUser);

            _mockwebUserRepository.Setup(q => q.GetWebUsers()).Returns(webUsers);

            var controller = new WebUserController(_mockwebUserRepository.Object);

            var result = controller.Index() as ViewResult;

            Assert.NotNull(result);
        }

        //private readonly IWebUserRepository _webUserRepository;

        //public WebUserControllerTest(IWebUserRepository webUserRepository)
        //{
        //    _webUserRepository = webUserRepository;
        //}

        //[Fact]
        //public void Index()
        //{
        //    // Db ile yapınca Rpository ile çalıştığımızdan onunda ayağaa kalkacak şekilde işlem yapmamız gerekecekti.Mow ile bunu yapmamıza gerkek kalmıyor.
        //    // Yaptığımızda ise burada oluşturduğumuz repository ile controller içindeki repositoryi eşleştiremiyor. Çünkü bu ayarları stratup.cs içinde yaptık.
        //    var controller = new WebUserController(_webUserRepository);
        //}
    }
}
