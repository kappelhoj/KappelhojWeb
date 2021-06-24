using MediatR;
using System;

namespace FoodPlanner.Commands.Interactors
{
    public abstract class Command<T> : IRequest<T> 
    {
        public Guid CorrelationId { get; set; }
    }
}
