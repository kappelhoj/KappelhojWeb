using FoodPlanner.Queries.ViewModels;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FoodPlanner.Queries.Recipes
{
    public class RecipesQuery : Query<RecipeViewModel>
    {

    }


    public class RecipesQueryHandler : IRequestHandler<RecipesQuery, RecipeViewModel>
    {
        public Task<RecipeViewModel> Handle(RecipesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
