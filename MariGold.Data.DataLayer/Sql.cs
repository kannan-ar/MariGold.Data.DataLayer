namespace MariGold.Data.DataLayer
{
	using System;
	using System.Data;
	
	internal sealed class Sql
	{
		private readonly string sql;
		private readonly CommandType commandType;
		
		internal Sql(string sql, CommandType commandType)
		{
			this.sql = sql;
			this.commandType = commandType;
		}
		
		internal string Text
		{
			get
			{
				return sql;
			}
		}
		
		internal CommandType CommandType
		{
			get
			{
				return commandType;
			}
		}
	}
}
