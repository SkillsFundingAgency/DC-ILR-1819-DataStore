﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ESFA.DC.ILR1819.DataStore.Interface;
using FastMember;

namespace ESFA.DC.ILR1819.DataStore.PersistData
{
    public sealed class BulkInsert : IBulkInsert
    {
        public async Task Insert<T>(string table, IEnumerable<T> source, SqlConnection sqlConnection, CancellationToken cancellationToken)
        {
            using (var sqlBulkCopy = BuildSqlBulkCopy(sqlConnection))
            {
                try
                {
                    if (!source.Any())
                    {
                        return;
                    }

                    if (cancellationToken.IsCancellationRequested)
                    {
                        return;
                    }

                    var columnNames = typeof(T).GetProperties().Where(p => !p.GetMethod.IsVirtual).Select(p => p.Name)
                        .ToArray();

                    using (var reader = ObjectReader.Create(source, columnNames))
                    {
                        sqlBulkCopy.DestinationTableName = table;

                        foreach (var name in columnNames)
                        {
                            sqlBulkCopy.ColumnMappings.Add(name, name);
                        }

                        await sqlBulkCopy.WriteToServerAsync(reader, cancellationToken);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(table);
                    Console.Write(ex);
                    throw;
                }
            }
        }

        private SqlBulkCopy BuildSqlBulkCopy(SqlConnection sqlConnection)
        {
            return new SqlBulkCopy(sqlConnection)
            {
                BatchSize = 5_000, // https://stackoverflow.com/questions/779690/what-is-the-recommended-batch-size-for-sqlbulkcopy
                BulkCopyTimeout = 600
            };
        }
    }
}
