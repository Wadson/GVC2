using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DAL
{
    public static class DataTableHelper
    {
        public static DataTable ExecuteReaderToDataTable(
            this SqliteConnection conn,
            string sql,
            object? param = null)
        {
            using var reader = conn.ExecuteReader(sql, param);
            return reader.ToDataTable();
        }

        public static DataTable ToDataTable(this IDataReader reader)
        {
            var ds = new DataSet();
            ds.EnforceConstraints = false;
            var dt = new DataTable();
            ds.Tables.Add(dt);
            dt.Load(reader);
            return dt;
        }
    }
}
