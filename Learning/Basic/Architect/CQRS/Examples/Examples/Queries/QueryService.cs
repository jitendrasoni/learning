using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Queries
{
    public class QueryService : IQueryService
    {
        private readonly string connectionstring;
        public QueryService ( string val)
        {
            connectionstring = val;
        }
        public Task<IEnumerable<int>> GetAllPostId()
        {
            throw new NotImplementedException();
        }
    }
}
