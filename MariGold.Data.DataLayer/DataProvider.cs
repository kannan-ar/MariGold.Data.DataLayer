namespace MariGold.Data.DataLayer
{
    using System;
    using System.Data;
    using System.Collections.Generic;
    using MariGold.Data;

    internal sealed class DataProvider : IDataProvider
    {
        private void ValidateArguments(IDbConnection connection, Query query)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            if (query == null)
            {
                throw new ArgumentNullException("query");
            }
        }

        public T Get<T>(IDbConnection connection, Query query)
        {
            ValidateArguments(connection, query);

            return connection.Get<T>(query.Sql, query.CommandType, query.Parameters);
        }

        public IList<T> GetList<T>(IDbConnection connection, Query query)
        {
            ValidateArguments(connection, query);

            return connection.GetList<T>(query.Sql, query.CommandType, query.Parameters);
        }

        public IEnumerable<T> GetEnumerable<T>(IDbConnection connection, Query query)
        {
            ValidateArguments(connection, query);

            return connection.GetEnumerable<T>(query.Sql, query.CommandType, query.Parameters);
        }
    }
}
