namespace MariGold.Data.DataLayer
{
	using System;
	using System.Data;
	using System.Collections.Generic;
	
	public abstract class Database
	{
		protected string sql;
		protected CommandType commandType;
		protected IDictionary<string,object> parameters;
		
		internal string Sql
		{
			set
			{
				sql = value;
			}
		}
		
		internal CommandType CommandType
		{
			set
			{
				commandType = value;
			}
		}
		
		internal IDictionary<string, object> Parameters
		{
			set
			{
				parameters = value;
			}
		}
	}
}
