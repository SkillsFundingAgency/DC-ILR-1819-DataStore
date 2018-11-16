﻿using System.Threading;
using System.Threading.Tasks;
using Autofac.Features.AttributeFilters;
using ESFA.DC.ILR.FundingService.FM35.FundingOutput.Model.Output;
using ESFA.DC.ILR1819.DataStore.Dto;
using ESFA.DC.ILR1819.DataStore.Interface;
using ESFA.DC.ILR1819.DataStore.Interface.Service;
using ESFA.DC.ILR1819.DataStore.PersistData.Constant;
using ESFA.DC.IO.Interfaces;
using ESFA.DC.Logging.Interfaces;
using ESFA.DC.Serialization.Interfaces;

namespace ESFA.DC.ILR1819.DataStore.PersistData.Services.Providers
{
    public class FM35ProviderService : BaseFundingModelProviderService<FM35Global>, IProviderService<FM35Global>
    {
        public FM35ProviderService(
            [KeyFilter(PersistenceStorageKeys.Redis)]
            IKeyValuePersistenceService keyValuePersistenceService,
            IJsonSerializationService jsonSerializationService,
            ILogger logger)
            : base(keyValuePersistenceService, jsonSerializationService, logger, FundModelConstants.FM35)
        {
        }

        public Task<FM35Global> ProvideAsync(IDataStoreContext dataStoreContext, CancellationToken cancellationToken)
        {
            return ReadAndDeserialiseFileAsync(dataStoreContext.FundingFM35OutputKey, cancellationToken);
        }
    }
}
