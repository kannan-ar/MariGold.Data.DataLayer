namespace MariGold.Data.DataLayer.Tests
{
	using System;
	using System.Data;
	using Dapper;
	
	public class DapperDatabase : Database
	{
		private readonly IDbConnection connection;
		
		public DapperDatabase(IDbConnection connection)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}
			
			this.connection = connection;
		}
		
		public int Execute()
		{
			return connection.Execute(sql, new DynamicParameters(parameters), commandType: commandType);
		}
		
		public T Get<T>()
		{
			return connection.ExecuteScalar<T>(sql, new DynamicParameters(parameters), commandType: commandType);
		}
	}
}
