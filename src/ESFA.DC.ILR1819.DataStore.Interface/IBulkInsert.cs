﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace ESFA.DC.ILR1819.DataStore.Interface
{
    public interface IBulkInsert
    {
        Task Insert<T>(string table, IList<T> source, SqlTransaction sqlTransaction, CancellationToken cancellationToken);
    }
}
