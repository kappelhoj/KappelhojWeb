using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPlanner.Commands.Interactors
{
    public class Response<T>
    {
        T Result { get; set; }
    }
}
