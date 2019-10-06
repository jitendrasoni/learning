using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Commands
{
    public interface ICommandService
    {
        Task<Models.Product> SaveProduct(string Id, String Name);
    }
}
