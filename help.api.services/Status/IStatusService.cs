using System.Collections.Generic;
using System.Threading.Tasks;

namespace help.api.services.Status
{
    public interface IStatusService
    {
        Task<IEnumerable<models.Status>> GetStatuses();
    }
}
