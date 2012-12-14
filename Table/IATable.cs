using System.Data;

namespace FunTest.Table
{
    public interface IATable
    {
        string TableName { get; }

        DataColumnCollection Columns { get; }
        DataRowCollection Rows { get; }
    }
}
