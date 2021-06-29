using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPlanner.Commands
{
    public class Response<T>
    {
        public T Result { get; set; }
    }
}
