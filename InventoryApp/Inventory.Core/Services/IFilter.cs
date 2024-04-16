using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryCore.Services
{
    public interface IFilter<T>
    {
        IEnumerable<T> FilterCollection(Collection<T> generalList);
        Task<IEnumerable<T>> FilterCollectionAsync(Collection<T> generalList, CancellationToken token);
    }
}
