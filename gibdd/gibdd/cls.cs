
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;


namespace gibdd
{
    static class cls
    {
        public static string safeGetString(this SqlDataReader result2, int colIndex)
        {

            if (!result2.IsDBNull(colIndex))
                return result2.GetString(colIndex);
            return string.Empty;
        }
    }
}
