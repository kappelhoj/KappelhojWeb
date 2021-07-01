using FoodPlanner.Commands.Integrations;
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

        private IRequestHandler<AddRecipeCommand, Response<Guid>> _addRecipeHandler;
        private Mock<IEntityPersister> _entityPersisterMock;

        public AddRecipeCommandTests() { 

            _entityPersisterMock = new Mock<IEntityPersister>();
            _entityPersisterMock.Setup(mock => mock.PersistEntity(It.IsAny<Recipe>())).Returns<Recipe>(x => Task.FromResult(x));
            _addRecipeHandler = new AddRecipeHandler(_entityPersisterMock.Object);
        }


        [Fact]
        public async void GivenValidRecipe_WhenAddingRecipe_ThenRecipeIdReturned() {
            //Arrange
            var addRecipeCommand = CreateValidAddRecipeCommand();

            //Act
            var response = await _addRecipeHandler.Handle(addRecipeCommand, default);

            //Assert
            Assert.NotEqual(Guid.Empty, response.Result);
        }

        [Fact]
        public async void GivenValidRecipe_WhenAddingRecipe_ThenRecipeEntityAdded()
        {
            //Arrange
            var addRecipeCommand = CreateValidAddRecipeCommand();
            Recipe? entityCreated = null;

            _entityPersisterMock.Setup(mock => mock.PersistEntity(It.IsAny<Recipe>()))
                .Callback<Recipe>(x => entityCreated = x)
                .Returns<Recipe>(x => Task.FromResult(x));

            //Act
            var response = await _addRecipeHandler.Handle(addRecipeCommand, default);

            //Assert
            _entityPersisterMock.Verify(mock => mock.PersistEntity(It.IsAny<Recipe>()), Times.Once);
            Assert.NotNull(entityCreated?.Id);
            Assert.Equal(response.Result, entityCreated?.Id);
            Assert.Equal(addRecipeCommand.Title, entityCreated?.Title);
        }



        private AddRecipeCommand CreateValidAddRecipeCommand() {
            return new AddRecipeCommand() { Title = "Meatballs" }; //TODO: Autofixture??
        }
    }
}
