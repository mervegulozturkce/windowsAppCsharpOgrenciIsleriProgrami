using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsAppCsharpOgrenciIsleriProgrami
{
	internal class DataLayer
	{
		internal static SqlConnection GetSqlConnection()
		{
			return new SqlConnection(@"Server=MERVEGUL\SQL_2025_STD_DEV; Initial Catalog=Ogrenci; Integrated Security=True; TrustServerCertificate=True;");
        }
	}
}
