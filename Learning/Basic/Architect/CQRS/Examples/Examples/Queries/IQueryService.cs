using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Queries
{
    public interface IQueryService
    {
        Task<IEnumerable<int>> GetAllPostId();
    }
}
