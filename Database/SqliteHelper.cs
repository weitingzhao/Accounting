using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace FunTest.Database
{
    public abstract class SqliteHelper
    {
        public static bool DBExist
        {
            get { return File.Exists(DefaultDBPath()); }
        }

        public static string DefaultDBPath()
        {
            var path = Application.StartupPath;
            var dbFile = "account.db";
            return Path.Combine(path, dbFile);
        }

        protected static SQLiteConnection CreateConn(string dataSource)
        {
          return new SQLiteConnection(string.Format(@"Data Source={0};Pooling=False;", dataSource));
        }

        protected static void ExeNonQuery(SQLiteCommand cmd, string format, params string[] args)
        {
            cmd.CommandText = string.Format(format, args);
            cmd.ExecuteNonQuery();
        }


        #region Get Columns & Values help function

        protected static string GetColumnNames(DataColumnCollection columns)
        {
            var result = new List<string>();

            foreach (DataColumn column in columns)
            {
                result.Add(column.ColumnName);
            }

            return string.Join(",", result);
        }

        protected static string GetValues(IEnumerable<object> values)
        {
            var result = new List<string>();

            foreach (var value in values)
            {
                result.Add(string.Format("'{0}'", value.ToString().Trim().Replace("'", "''")));
            }

            return string.Join(",", result);
        }

        #endregion
    }
}
