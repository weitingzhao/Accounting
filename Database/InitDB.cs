namespace FunTest.Database
{
    public class InitDB : SqliteHelper
    {
        public void Init()
        {
            var dbPath = DefaultDBPath();

            using(var conn = CreateConn(dbPath))
            {
                conn.Open();

                var cmd = conn.CreateCommand();
                
                //a. Delete existing data
                ExeNonQuery(cmd, "DROP TABLE IF EXISTS Description");
                ExeNonQuery(cmd, "DROP TABLE IF EXISTS Accounts");
                ExeNonQuery(cmd, "DROP INDEX IF EXISTS Idx_Acounts_SerialId");
                ExeNonQuery(cmd, "DROP INDEX IF EXISTS Idx_Accounts_PostDate");

                //b. Add
                ExeNonQuery(cmd, "CREATE TABLE Description (Category TEXT, Name TEXT, Comm TEXT)");
                ExeNonQuery(cmd, "CREATE TABLE Accounts (SerialId INTEGER PRIMARY KEY, PostDate TEXT, Type TEXT, Description TEXT, Amount NUMBERIC, Comm TEXT)");
                ExeNonQuery(cmd, "CREATE INDEX Idx_Acounts_SerialId ON Accounts(SerialId ASC)");
                ExeNonQuery(cmd, "CREATE INDEX Idx_Accounts_PostDate ON Accounts(PostDate DESC)");

                conn.Close();
            }
        }

    }
}
