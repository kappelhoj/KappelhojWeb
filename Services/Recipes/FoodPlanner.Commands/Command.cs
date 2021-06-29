using MediatR;
using System;

namespace FoodPlanner.Commands
{
    public abstract class Command<T> : IRequest<T> 
    {
        //TODO: Tie this to the current Scoped context
        public Guid CorrelationId { get; set; }
    }
}
