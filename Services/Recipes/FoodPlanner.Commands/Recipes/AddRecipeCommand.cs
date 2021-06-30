using FoodPlanner.Commands.Integrations;
using FoodPlanner.Domain.Recipes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FoodPlanner.Commands.Recipes
{
    public class AddRecipeCommand : Command<Response<Guid>>
    {
        public string Title { get; set; }

    }

    public class AddRecipeHandler : IRequestHandler<AddRecipeCommand, Response<Guid>>
    {
        private readonly IRepository _repository;

        public AddRecipeHandler(IRepository repository)
        {
            _repository = repository;
        }


       async Task<Response<Guid>> IRequestHandler<AddRecipeCommand, Response<Guid>>.Handle(AddRecipeCommand request, CancellationToken cancellationToken)
        {
            var recipe = new Recipe()
            {
                Id = Guid.NewGuid(),
                Title = request.Title
            };

            await _repository.AddEntity(recipe);

            return new Response<Guid>
            {
                Result = recipe.Id
            };
        }
    }
}
