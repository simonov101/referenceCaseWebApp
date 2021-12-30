using Microsoft.AspNetCore.Mvc;
using referenceCaseWebApp.Controllers;
using referenceCaseWebApp.Model;
using referenceCaseWebApp.Repository;
using System;
using System.Collections.Generic;
using Xunit;

namespace referenceCaseWepApp.Test
{
    public class CategoryControllerTest
    {
        CategoryController _controller;
        CategoryRepository _categoryRepository;

        public CategoryControllerTest()
        {
            _categoryRepository = new CategoryRepository();
            _controller = new CategoryController(_categoryRepository);
        }

        [Fact]
        public void GetAllTest()
        {
            //Arrange
            //Act
            var result = _controller.Get();
            //Assert
            Assert.IsType<OkObjectResult>(result.Result);

            var list = result.Result as OkObjectResult;

            Assert.IsType<List<Category>>(list.Value);



            var listCategories = list.Value as List<Category>;

            Assert.Equal(2, listCategories.Count);
        }
    }
}
