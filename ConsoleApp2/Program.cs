using System.Data.SqlClient;

SqlConnection conn = new SqlConnection("Data Source=SUNUM1\\MSSQLSERVER2014;Initial Catalog =Calisma;User ID = sa; Password = 1230");
conn.Open();

SqlCommand cmd = new SqlCommand("Select * from Personel waitfor delay '0:0:1' ", conn);

IAsyncResult result = cmd.BeginExecuteReader();

int sayac = 1;
while (!result.IsCompleted)
{
    Console.WriteLine(sayac++);
}
SqlDataReader dr = cmd.EndExecuteReader(result);

while (dr.Read())
{
    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
}

conn.Close();