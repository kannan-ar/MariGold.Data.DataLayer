namespace MariGold.Data.DataLayer.Tests
{
	using System;
	using System.Data;
	
	public class SqlDatabase : Database
	{
		private readonly string connectionString;
		
		public SqlDatabase(string connectionString)
		{
			if (string.IsNullOrEmpty(connectionString))
			{
				throw new ArgumentNullException("connectionString");
			}
			
			this.connectionString = connectionString;
		}
		
		public IDataReader GetDataReader()
		{
			throw new NotImplementedException();
		}
		
		public void Execute()
		{
			throw new NotImplementedException();
		}
		
		public T Get<T>()
		{
			throw new NotImplementedException();
		}
	}
}
