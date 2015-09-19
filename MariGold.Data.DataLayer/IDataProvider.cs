namespace MariGold.Data.DataLayer
{
    using System;
    using System.Data;
    using System.Collections.Generic;

    public interface IDataProvider
    {
        T Get<T>(IDbConnection connection, Query query);
        IList<T> GetList<T>(IDbConnection connection, Query query);
        IEnumerable<T> GetEnumerable<T>(IDbConnection connection, Query query);
    }
}
