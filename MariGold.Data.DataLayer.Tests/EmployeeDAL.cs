﻿namespace MariGold.Data.DataLayer.Tests
{
	using System;
	using System.Data;
	using System.Collections.Generic;
	
	public class EmployeeDAL : DataProvider<DapperDatabase>
	{
		public enum Queries
		{
			GET_BY_ID
		}
		
		public EmployeeDAL(DapperDatabase db)
			: base(db)
		{
		}
		
		protected override void RegisterQueries(SqlContainer container)
		{
			container.Add(Queries.GET_BY_ID.ToString(), CommandType.Text, "Select Id, Name From Employee Where Id = @Id");
		}
	}
}
