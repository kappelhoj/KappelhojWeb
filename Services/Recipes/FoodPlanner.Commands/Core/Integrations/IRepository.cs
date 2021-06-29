using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPlanner.Commands.Core.Integrations
{
    public interface IRepository
    {
        public T AddEntity<T>(T entity);

    }
}
