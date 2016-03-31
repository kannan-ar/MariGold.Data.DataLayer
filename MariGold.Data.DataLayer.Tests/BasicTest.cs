namespace MariGold.Data.DataLayer.Tests
{
	using System;
	using NUnit.Framework;
	using System.Data.SqlClient;
	
	[TestFixture]
	public class BasicTest
	{
		[Test]
		public void BareMinimum()
		{
			using (SqlConnection conn = new SqlConnection(@"Server=10.6.0.116\sqlexpress;Database=Tests;User Id=testusr;Password=pass@word1;"))
			{
				EmployeeDAL dal = new EmployeeDAL(new DapperDatabase(conn));
			
				Employee employee = dal[EmployeeDAL.Queries.GET_BY_ID.ToString()].AddParam("1", 1).Db.Get<Employee>();
			}
		}
	}
}
