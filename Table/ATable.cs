using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FunTest.Table
{
    public abstract class ATable<TRow> : DataTable, IATable
    {

        protected ATable(string tableName)
        {
            this.TableName = tableName;

            this.LoadColumns(GeneralDataColumns());
        }

        public abstract DataColumn[] GeneralDataColumns();

        private void LoadColumns(IEnumerable<DataColumn> dataColumns)
        {
            if (dataColumns == null || dataColumns.Count() <= 0) return;
            foreach (var dataColumn in dataColumns)
            {
                this.Columns.Add(dataColumn);
            }
        }

        protected override Type GetRowType()
        {
            
            return typeof(TRow);
        }

        public TRow NewRecord()
        {
            return (TRow)(object)this.NewRow();
        }
    }
}
