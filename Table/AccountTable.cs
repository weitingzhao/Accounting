using System.Data;
using FunTest.Table.Row;

namespace FunTest.Table
{
    public class AccountTable : ATable<AccountRecord>
    {
        public AccountTable() : base("Accounts")
        {
        }

        public override DataColumn[] GeneralDataColumns()
        {
            return new[]
                       {
                           DataTableUtils.GetColumn("SerialId", typeof (int), false, true, true),
                           DataTableUtils.GetColumn("PostDate", typeof (string), false, false, false),
                           DataTableUtils.GetColumn("Type", typeof (string), true),
                           DataTableUtils.GetColumn("Description", typeof (string), true),
                           DataTableUtils.GetColumn("Amount", typeof (string), true),
                           DataTableUtils.GetColumn("Comm", typeof (string), true)
                       };
        }
        
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new AccountRecord(builder);
        }
    }
}
