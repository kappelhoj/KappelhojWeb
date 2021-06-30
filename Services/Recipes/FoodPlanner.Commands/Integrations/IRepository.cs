using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPlanner.Commands.Integrations
{
    public interface IRepository
    {
        public Task<T> AddEntity<T>(T entity);

    }
}
