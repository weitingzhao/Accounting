namespace FunTest.Database
{
    public class GetDB : SqliteHelper
    {
        //public static void GetTypes(IATable table)
        //{
        //    var dbPath = DefaultDBPath();

        //    using (var conn = CreateConn(dbPath))
        //    {
        //        conn.Open();
        //        var cmd = conn.CreateCommand();

        //        var columnNames = GetColumnNames(table.Columns);
        //        foreach (BaseRecord row in table.Rows)
        //        {
        //            ExeNonQuery(cmd, "INSERT INTO {0} ({1}) VALUES ({2})",
        //                table.TableName, columnNames, GetValues(row.ItemArray));
        //        }
        //        conn.Close();
        //    }
        //}
    }
}
