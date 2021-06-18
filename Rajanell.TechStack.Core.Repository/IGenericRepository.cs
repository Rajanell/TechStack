using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Core.Repository
{
    public interface IGenericRepository<T> : ICommandRepository<T>, IQueryRepository<T> where T : class
    {
    }
}
