namespace MariGold.Data.DataLayer
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	
	public sealed class SqlContainer
	{
		private readonly IDictionary<string,Sql> queries;
		
		internal bool HasQuery(string name)
		{
			return queries.ContainsKey(name);
		}
		
		public SqlContainer()
		{
			queries = new Dictionary<string, Sql>();
		}
		
		public void Add(string name, CommandType commandType, string sql)
		{
			if (HasQuery(name))
			{
				throw new ArgumentException(string.Concat(name, " is already registered"));
			}
			
			Sql query = new Sql(sql, commandType);
			
			queries.Add(name, query);
		}
		
		internal bool TryGetSql(string name, out Sql query)
		{
			return queries.TryGetValue(name, out query);
		}
	}
}
