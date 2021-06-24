using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Interactors.Commands
{
    public abstract class Command<T> : IRequest<T> 
    {
        public Guid CorrelationId { get; set; }
    }
}
