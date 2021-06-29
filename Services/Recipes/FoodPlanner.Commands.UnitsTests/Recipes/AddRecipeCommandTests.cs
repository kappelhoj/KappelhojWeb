using FoodPlanner.Commands.Core.Integrations;
using FoodPlanner.Commands.Recipes;
using FoodPlanner.Domain.Recipes;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FoodPlanner.Commands.UnitTests.Recipes
{
    public class AddRecipeCommandTests
    {

        private Mock<IRepository> _repositoryMock;

        public AddRecipeCommandTests() { 

            _repositoryMock = new Mock<IRepository>();
            _repositoryMock.Setup(mock => mock.AddEntity(It.IsAny<Recipe>())).Returns<Recipe>(x => x);
        }


        [Fact]
        public async void GivenValidRecipe_WhenAddingRecipe_ThenRecipeIdReturned() {
            //Arrange
            var addRecipeCommand = CreateValidAddRecipeCommand();

            IRequestHandler<AddRecipeCommand, Response<Guid>> addRecipeHandler = new AddRecipeHandler(_repositoryMock.Object);

            //Act
            var response = await addRecipeHandler.Handle(addRecipeCommand, default);

            //Assert
            Assert.NotEqual(Guid.Empty, response.Result);
        }

        [Fact]
        public async void GivenValidRecipe_WhenAddingRecipe_ThenRecipeEntityAdded()
        {
            //Arrange
            var addRecipeCommand = CreateValidAddRecipeCommand();
            Recipe? entityCreated = null;

            _repositoryMock.Setup(mock => mock.AddEntity(It.IsAny<Recipe>()))
                .Callback<Recipe>(x => entityCreated = x)
                .Returns<Recipe>(x => x);

            IRequestHandler<AddRecipeCommand, Response<Guid>> addRecipeHandler = new AddRecipeHandler(_repositoryMock.Object);

            //Act
            var response = await addRecipeHandler.Handle(addRecipeCommand, default);

            //Assert
            _repositoryMock.Verify(mock => mock.AddEntity(It.IsAny<Recipe>()), Times.Once);
            Assert.NotNull(entityCreated?.Id);
            Assert.Equal(response.Result, entityCreated?.Id);
            Assert.Equal(addRecipeCommand.Title, entityCreated?.Title);
        }



        private AddRecipeCommand CreateValidAddRecipeCommand() {
            return new AddRecipeCommand() { Title = "Meatballs" }; //TODO: Autofixture??
        }
    }
}
