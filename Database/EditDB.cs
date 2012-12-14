using System.Collections.Generic;
using FunTest.Table;
using FunTest.Table.Row;

namespace FunTest.Database
{
    public class EditDB : SqliteHelper
    {
        public static void AddRecords(IATable table)
        {
            var dbPath = DefaultDBPath();

            using (var conn = CreateConn(dbPath))
            {
                conn.Open();
                var cmd = conn.CreateCommand();

                var columnNames = GetColumnNames(table.Columns);
                foreach (BaseRecord row in table.Rows)
                {
                    ExeNonQuery(cmd, "INSERT INTO {0} ({1}) VALUES ({2})", 
                        table.TableName, columnNames, GetValues(row.ItemArray));
                }
                conn.Close();
            }
        }

        public static void UpdateRecords(IATable table)
        {
            var dbPath = DefaultDBPath();

            using (var conn = CreateConn(dbPath))
            {
                conn.Open();
                var cmd = conn.CreateCommand();

                
                foreach (BaseRecord row in table.Rows)
                {
                    var values = new List<string>();
                    var pks = new List<string>();

                    //Get Values & Primary Keys
                    for (var i = 0; i < table.Columns.Count; i++)
                    {
                        var column = table.Columns[i];
                        var value = row.ItemArray[i];

                        var script = string.Format("{0}='{1}'", column, value.ToString().Trim().Replace("'", "''"));
                        
                        //Add into Values or Primary keys
                        if (DataTableUtils.IsPartOfPrimaryColumn(column))
                            pks.Add(script);
                        else
                            values.Add(script);
                    }
                    ExeNonQuery(cmd, "UPDATE {0} SET {1} WHERE {2}", 
                        table.TableName, string.Join(",", values), string.Join(" AND ", pks));
                }

                conn.Close();
            }
        }

    }
}
