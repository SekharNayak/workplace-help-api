using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help.api.services.Status
{
    public interface IStatusService
    {
        Task<IEnumerable<help.api.models.Status>> GetStatuses();
    }
}
