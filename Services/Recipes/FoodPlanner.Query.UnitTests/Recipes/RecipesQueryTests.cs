using FoodPlanner.Queries.Recipes;
using FoodPlanner.Queries.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FoodPlanner.Query.UnitTests.Recipes
{
    public class RecipesQueryTests
    {

        [Fact]
        public void Test() {
            //Arrange
            var recipesQuery = new RecipesQuery();

            IRequestHandler<RecipesQuery, RecipeViewModel> recipesQueryHandler = new RecipesQueryHandler();


            //Act

            //Assert

        }
    }
}
