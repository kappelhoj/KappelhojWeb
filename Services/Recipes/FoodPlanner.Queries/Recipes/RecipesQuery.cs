using FoodPlanner.Application.Core.Contracts.Infrastructure;
using FoodPlanner.Queries.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FoodPlanner.Queries.Recipes
{
    public class RecipesQuery : Query<Response<IEnumerable<RecipeViewModel>>>
    {
        public int PageSize { get; set; } = 15;
    }


    public class RecipesQueryHandler : IRequestHandler<RecipesQuery, Response<IEnumerable<RecipeViewModel>>>
    {
        public Task<Response<IEnumerable<RecipeViewModel>>> Handle(RecipesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
