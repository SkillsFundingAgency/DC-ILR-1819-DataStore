﻿using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR1819.DataStore.Interface
{
    public interface IStoreValidationOutput
    {
        Task StoreAsync(IDataStoreContext dataStoreContext, SqlTransaction sqlTransaction, int ukPrn, IMessage ilr, CancellationToken cancellationToken);
    }
}
