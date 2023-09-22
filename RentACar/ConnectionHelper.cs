using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class ConnectionHelper
    {
        public static string ConnectionString
        {
            get
            {
                string db = Path.Combine(Path.GetFullPath("..\\..\\"), "carOrderdb.mdf");
                return $@"Data Source=(localdb)\mssqllocaldb; AttachDbFilename={db}; Initial Catalog=carOrderdb.mdf; Trusted_Connection=True";
            }
        }
    }
}
