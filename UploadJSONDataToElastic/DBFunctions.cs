using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UploadJSONDataToElastic
{
    public class DBFunctions
    {
        public DataTable getResultSetFromtext(string qeury, string connectionString)
        {
            DataTable clientResult = null;
            try
            {
                
            }
            catch(Exception ex)
            {
                //Log The exception
            }
            return clientResult;
        }

        public DataTable getResultSetFromProc(string procName, string connectionString)
        {
            DataTable clientResult = null;
            try
            {

            }
            catch(Exception ex)
            {
                //Log the execption
            }
            return clientResult;
        }

    }
}
