// See https://aka.ms/new-console-template for more information
using HADotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

//Console.WriteLine("Hello, World!");

//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = "DESKTOP-RC4ESUP";
//stringBuilder.InitialCatalog = "HADotNetCore";
//stringBuilder.UserID = "sa";
//stringBuilder.Password = "sa@123";

//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
//connection.Open();
//Console.WriteLine("Connection open");
//string query = "select *from Tbl_blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);

////Console.WriteLine("Connection close");
//foreach (DataRow dr in dt.Rows)
//{
//  Console.WriteLine("Blog ID =>" + dr["BlogId"]);
//   Console.WriteLine("Blog Title=>" + dr["BlogTitle"]);
//   Console.WriteLine("Blog Author =>" + dr["BlogAuthor"]);
//   Console.WriteLine("Blog Content =>" + dr["BlogContent"]);
//   Console.WriteLine("------------------------------------");
//}
AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//.adoDotNetExampleUpdate(12,"test title", "test authorr", "test content");

//adoDotNetExample.Delete(11);
adoDotNetExample.Edit(11);
//Console.ReadKey();