namespace MariGold.Data.DataLayer
{
    using System;
    using System.Data;
    using System.Collections.Generic;

    public abstract class QueryProvider
    {
        private IDictionary<string, Query> _queries;
        private IDataProvider _provider;
        private IDbConnection _connection;

        public QueryProvider()
        {
            _provider = new DataProvider();
            _queries = new Dictionary<string, Query>();
            _connection = GetConnection();

            RegisterQuery(_queries);
        }

        public QueryProvider(IDataProvider provider)
        {
            if (provider == null)
            {
                throw new ArgumentNullException("provider");
            }

            _provider = provider;
            _queries = new Dictionary<string, Query>();
            _connection = GetConnection();

            RegisterQuery(_queries);
        }

        public abstract void RegisterQuery(IDictionary<string, Query> queries);
        public abstract IDbConnection GetConnection();

        public T Get<T>(string name, IDictionary<string, object> parameters = null)
        {
            Query query;

            if (_queries.TryGetValue(name, out query))
            {
                query.MergeParameters(parameters);

                return _provider.Get<T>(_connection, query);
            }
            else
            {
                throw new ArgumentOutOfRangeException(name + " not found");
            }
        }

        public IList<T> GetList<T>(string name, IDictionary<string, object> parameters = null)
        {
            Query query;

            if (_queries.TryGetValue(name, out query))
            {
                query.MergeParameters(parameters);

                return _provider.GetList<T>(_connection, query);
            }
            else
            {
                throw new ArgumentOutOfRangeException(name + " not found");
            }
        }

        public IEnumerable<T> GetEnumerable<T>(string name, IDictionary<string, object> parameters = null)
        {
            Query query;

            if (_queries.TryGetValue(name, out query))
            {
                query.MergeParameters(parameters);

                return _provider.GetEnumerable<T>(_connection, query);
            }
            else
            {
                throw new ArgumentOutOfRangeException(name + " not found");
            }
        }
    }
}
