using System.Data;

namespace FunTest.Table.Row
{
    public class DescriptionRecord : BaseRecord
    {
        protected internal DescriptionRecord(DataRowBuilder builder) : base(builder) { }

        public string Category
        {
            get { return GetString("Category"); }
            set { this["Category"] = value; }
        }
        
        public string Name
        {
            get { return GetString("Name"); }
            set { this["Name"] = value; }
        }

        public string Comm
        {
            get { return GetString("Comm"); }
            set { this["Comm"] = value; }
        }
    }
}
