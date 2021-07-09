using Rajanell.TechStach.Core.Model.Common;
using Rajanell.TechStach.Core.Model.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Core.Repository
{
    public interface IPagedQueryRepository<T>
    {
        Task<PagedList<T>> GetAll(ResourceParameters resourceParameters);
        Task<PagedList<T>> Find(Expression<Func<T, bool>> query, ResourceParameters resourceParameters);
    }
}
