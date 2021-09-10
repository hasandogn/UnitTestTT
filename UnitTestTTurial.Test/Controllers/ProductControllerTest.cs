using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestTT.Controllers;
using UnitTestTT.Model;
using Xunit;

namespace UnitTestTTurial.Test.Controllers
{
    public class ProductControllerTest
    {
        [Fact]
        public void Index()
        {
            var controller = new ProductController();
            var result = controller.Index() as ViewResult;

            // En başta çalışmalı
            Assert.NotNull(result);

            //actionResult sonucu dönen model yakalanır VE İSTEDİĞİMİZ CLASSA CAST ETTİK
            var model = result.ViewData.Model as List<ProductVM>;
            Assert.True(model.Count > 0);
            Assert.Equal(2, model.Count);
            
            //var model = Assert.IsAssignableFrom<IEnumerable<ProductVm>>(result.ViewData.Model) as List<ProductVM>;
        }
    }
}
