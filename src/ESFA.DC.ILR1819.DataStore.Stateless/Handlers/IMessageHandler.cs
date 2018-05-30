﻿using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.JobContext;

namespace ESFA.DC.ILR1819.DataStore.Stateless.Handlers
{
    public interface IMessageHandler
    {
        Task<bool> Handle(JobContextMessage jobContextMessage, CancellationToken cancellationToken);
    }
}