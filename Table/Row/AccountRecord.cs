using System.Data;

namespace FunTest.Table.Row
{
    public class AccountRecord : BaseRecord
    {
        protected internal AccountRecord(DataRowBuilder builder) : base(builder){ }

        public int SerialId
        {
            get { return GetInt("SerialId"); }
            set { this["SerialId"] = value; }
        }

        public string PostDate
        {
            get { return GetString("PostDate"); }
            set { this["PostDate"] = value; }
        }

        public string Type
        {
            get { return GetString("Type"); }
            set { this["Type"] = value; }
        }

        public string Description
        {
            get { return GetString("Description"); }
            set { this["Description"] = value; }
        }

        public string Amount
        {
            get { return GetString("Amount"); }
            set { this["Amount"] = value; }
        }

        public string Comm
        {
            get { return GetString("Comm"); }
            set { this["Comm"] = value; }
        }
    }
}
