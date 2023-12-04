namespace KeyHolder.Classes
{
    public abstract class ActiveRecord<T>
        where T : class
    {
        public String ConnectionString
        {
            get
            {
                var path = "C:\\sources\\claviculario\\claviculario\\data\\keys.xlsx";
                // if the File extension is .XLSX using below connection string
                return "Provider=Microsoft.ACE.OLEDB.12.0;" +
                          "Data Source='" + path +
                          "';Extended Properties=\"Excel 12.0;HDR=YES;\"";

            }
        }

        public abstract int Save();
        public abstract int Delete();
        public abstract List<T> Find(T obj);
    }
}