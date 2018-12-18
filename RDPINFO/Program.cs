using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDPINFO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TerminalSessionData> listSessions = new List<TerminalSessionData>();
            listSessions = TerminalSession.ListSessions("");
            //String SESSIONID = listSessions[0].ToString();
            string errorpath = AppDomain.CurrentDomain.BaseDirectory.ToString();
            foreach (TerminalSessionData tmpses in listSessions)
            {
                File.AppendAllText(errorpath + "sessions.txt", "Station Name: " + tmpses.StationName.ToString() + " ---> Sesion ID: " + tmpses.SessionId.ToString());
                //tmpses.SessionId.ToString();
                //tmpses.StationName.ToString();
            }
        }
    }
}
