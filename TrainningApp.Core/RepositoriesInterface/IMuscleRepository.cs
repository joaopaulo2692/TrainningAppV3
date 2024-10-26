using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Entities;

namespace TrainningApp.Core.RepositoriesInterface
{
    public interface IMuscleRepository
    {
        public Task<Muscle> FindByNameAsync(string name);
    }
}
