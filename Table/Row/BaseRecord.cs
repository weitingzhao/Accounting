using System;
using System.Data;

namespace FunTest.Table.Row
{
    public class BaseRecord : DataRow
    {
        protected internal BaseRecord(DataRowBuilder builder)
            : base(builder)
        {
        }


        #region Get Object

        public string GetString(string columnName)
        {
            var obj = Clearn(columnName);
            return obj == null ? null : ((string)obj).Trim();
        }


        public int GetInt(string columnName)
        {
            var obj = Clearn(columnName);
            return obj == null ? -1 : (int)obj;
        }


        public bool GetBool(string columnName)
        {
            var obj = Clearn(columnName);
            return obj == null ? false : (bool)obj;
        }


        public DateTime GetDateTime(string columnName)
        {
            var obj = Clearn(columnName);
            return obj == null ? new DateTime(1900, 1, 2) : (DateTime)obj;
        }

        public long GetLong(string columnName)
        {
            var obj = Clearn(columnName);
            return obj == null ? -1 : (long)obj;
        }

        public decimal GetDecimal(string columnName)
        {
            var obj = Clearn(columnName);
            return obj == null ? -1 : (decimal)obj;
        }

        private object Clearn(string columnName)
        {
            try
            {
                var obj = this[columnName];
                return obj == DBNull.Value ? null : obj;
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        #endregion
    }
}
