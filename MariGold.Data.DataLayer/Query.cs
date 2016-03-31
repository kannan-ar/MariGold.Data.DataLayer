namespace MariGold.Data.DataLayer
{
	using System;
	using System.Collections.Generic;
	
	public sealed class Query<T>
		where T : Database
	{
		private readonly Sql sql;
		private readonly IDictionary<string, object> parameters;
		private readonly T db;
		
		internal Query(Sql sql, T db)
		{
			this.sql = sql;
			parameters = new Dictionary<string,object>();
			this.db = db;
		}
		
		public Query<T> AddParam(string paramName, object value)
		{
			parameters.Add(paramName, value);
			return this;
		}
		
		public T Db
		{
			get
			{
				db.Sql = sql.Text;
				db.CommandType = sql.CommandType;
				db.Parameters = parameters;
				return db;
			}
		}
	}
}
