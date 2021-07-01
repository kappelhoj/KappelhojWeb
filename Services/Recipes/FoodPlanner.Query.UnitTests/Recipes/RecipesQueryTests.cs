using FoodPlanner.Application.Core.Contracts.Infrastructure;
using FoodPlanner.Queries.Recipes;
using FoodPlanner.Queries.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace FoodPlanner.Query.UnitTests.Recipes
{
    public class RecipesQueryTests
    {
        IRequestHandler<RecipesQuery, Response<IEnumerable<RecipeViewModel>>> _recipesQueryHandler;


        public RecipesQueryTests() {
            _recipesQueryHandler = new RecipesQueryHandler();
        }

        [Fact]
        public async void WhenQueryRecipes_ThenRecipesCountMatchDefaultPageSize() {
            //Arrange
            var recipesQuery = new RecipesQuery();

            //Act
            var response = await _recipesQueryHandler.Handle(recipesQuery, CancellationToken.None);

            //Assert
            Assert.Equal(recipesQuery.PageSize, response.Result.Count());
        }
    }
}
