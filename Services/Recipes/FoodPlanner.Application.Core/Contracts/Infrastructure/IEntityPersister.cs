using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPlanner.Commands.Integrations
{
    public interface IEntityPersister
    {
        public Task<T> PersistEntity<T>(T entity);

    }
}
