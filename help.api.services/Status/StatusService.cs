using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using help.api.models;
using help.api.repositories;

namespace help.api.services.Status
{
    public class StatusService : IStatusService
    {

        private readonly IStatusRepository statusRepository = null;


        public StatusService(IStatusRepository statusRepository)
        {
            this.statusRepository = statusRepository;
        }
        public Task<IEnumerable<models.Status>> GetStatuses()
        {
            return Task.Run<IEnumerable<models.Status>>(() => {
                return statusRepository.Get();
            });
        }
    }
}
