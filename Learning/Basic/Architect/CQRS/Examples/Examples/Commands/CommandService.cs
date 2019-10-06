using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Examples.Models;

namespace Examples.Commands
{
    public class CommandService : ICommandService
    {
        private readonly string connectionstring;
        public CommandService(string val)
        {
            connectionstring = val;
        }

        public Task<Product> SaveProduct(string Id, string Name)
        {
            throw new NotImplementedException();
        }
    }
}
