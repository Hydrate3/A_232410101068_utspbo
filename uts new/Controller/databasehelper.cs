using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

string connString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=UTS_PBO";

NpgsqlConnection conn = new NpgsqlConnection(connString);
conn.Open();
string query = "SELECT * FROM kontak";
using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
    {
    DataTable dataTable = new DataTable();
    adapter.Fill(dataTable);
    }

