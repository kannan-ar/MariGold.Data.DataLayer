namespace MariGold.Data.DataLayer.Tests
{
	using System;
	using NUnit.Framework;

	[TestFixture]
	public class BasicTest
	{
		[Test]
		public void BareMinimum()
		{
			EmployeeDAL dal = new EmployeeDAL(new SqlDatabase(""));
			
			Employee employee = dal[EmployeeDAL.Queries.GET_BY_ID.ToString()].AddParam("1", 1).Db.Get<Employee>();
		}
	}
}
