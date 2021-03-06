﻿using Microsoft.ServiceFabric.Services.Remoting;
using Microsoft.ServiceFabric.Services.Remoting.FabricTransport;
using System.Threading.Tasks;

namespace Streamer.Common.Contracts
{
    public interface IOrchestrator : IService
    {
        /// <summary>
        /// Ensures that a worker service is spun up, with the correct worker description. 
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        Task<string> OrchestrateWorker(WorkerDescription workerDescription);
    }
}
