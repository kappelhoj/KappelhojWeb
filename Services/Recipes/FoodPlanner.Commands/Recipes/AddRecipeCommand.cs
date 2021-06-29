using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FoodPlanner.Commands.Recipes
{
    public class AddRecipeCommand : Command<Response<string>>
    {
    }

    public class AddRecipeHandler : IRequestHandler<AddRecipeCommand, Response<string>>
    {

        Task<Response<string>> IRequestHandler<AddRecipeCommand, Response<string>>.Handle(AddRecipeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }



}
