namespace MariGold.Data.DataLayer
{
	using System;
	
	public abstract class DataProvider<T>
		where T : Database
	{
		private readonly SqlContainer container;
		private readonly T db;
		
		protected abstract void RegisterQueries(SqlContainer container);
		
		public DataProvider(T db)
		{
			if (db == null)
			{
				throw new ArgumentNullException("db");
			}
			
			this.db = db;
			container = new SqlContainer();
			RegisterQueries(container);
		}
		
		public Query<T> this[string name]
		{
			get
			{
				Sql query;
				
				if (!container.TryGetSql(name, out query))
				{
					throw new ArgumentException(string.Concat(name, " is not found"));
				}
				
				return new Query<T>(query, db);
			}
		}
	}
}
