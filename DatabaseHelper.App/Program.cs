using DatabaseHelper.MsSql;
using System.Data;

namespace DatabaseHelper.App
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using SqlDatabase database = new("server = .; database = northwind; integrated security = true; TrustServerCertificate=true;");

			DataTable table = database.GetDataTable("Select * From Products");

			foreach (DataRow dr in table.Rows)
			{
				Console.WriteLine($"{dr["ProductID"]} {dr["ProductName"]}");
			}

			//try
			//{
			//	database.OpenConnection();
			//	database.BeginTransaction();
			//	for (int i = 0; i < 10; i++)
			//	{
			//		if (i == 6)
			//		{
			//			throw new Exception();
			//		}
			//		database.ExecuteNonQuery("insert into Products(CategoryID,code,ProductName,Price) values(1015,'0011','Snikers', 5.89);");
			//	}
			//	database.CommitTransaction();
			//}
			//catch
			//{
			//	database.RollBackTransaction();
			//}
		}
	}
}