using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTools
{
	internal class GET_I200xI250
	{
		public void ExecuteSelect(string connectionString)
		{
			try
			{
				using (SqlConnection connection = new(connectionString))
				{
					connection.Open();

					CreateDynamicTable(connection);

					connection.Close();
				}

				Console.WriteLine($"Concluído: {csvFilePath}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Erro ao importar o arquivo: {csvFilePath} Mensagem: {ex.Message}");
			}
		}

	}
}
