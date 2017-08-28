using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsUtilitarios
{
    public class Log
    {
        public void ArchiveLog(string strModulo, string strMensaje)
        {
            string strPath = FilePath.LogPath;
            string strPathLog = strPath + @"\Eagle_Log.log";

            using (StreamWriter sw = new StreamWriter(strPathLog, true, Encoding.Default))
            {
                try
                {
                    StringBuilder str = new StringBuilder();
                    str.Append(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " || " + strModulo + " --> " + strMensaje);
                    sw.WriteLine(str);
                    str.AppendLine();
                    sw.Close();
                }
                catch
                {
                    sw.Close();
                }
            }
        }
    }
}
