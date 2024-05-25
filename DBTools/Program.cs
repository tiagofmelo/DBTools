namespace DBConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connectionString = "Data Source=10.22.0.212\\INST1;Initial Catalog=DBEYCLIENT_33040981000150;Integrated Security=True;Connect Timeout=0;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			GET_I200xI250 get = new();

			get.ExecuteSelect(connectionString);

			Console.ReadLine();
		}
	}
}
