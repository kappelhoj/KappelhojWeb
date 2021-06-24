using Recipes.Interactors.Core;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Recipes.Interactors.Commands.Recipes
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
