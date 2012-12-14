using System.Data;
using FunTest.Table.Row;

namespace FunTest.Table
{
    public class DescriptionTable : ATable<DescriptionRecord>
    {
        public DescriptionTable() : base("Description")
        {
        }

        public override DataColumn[] GeneralDataColumns()
        {
            return new[]
                       {
                           DataTableUtils.GetColumn("Name", typeof (string), false, true, true),
                           DataTableUtils.GetColumn("Category", typeof (string), true),
                           DataTableUtils.GetColumn("Comm", typeof (string), true)
                       };
        }

        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new DescriptionRecord(builder);
        }
    }
}
