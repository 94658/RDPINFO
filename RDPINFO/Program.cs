using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RDPINFO.TerminalSession;

namespace RDPINFO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string servername = "";
            TerminalSession terminalSession = new TerminalSession();
            List<TerminalSessionData> listSessions = new List<TerminalSessionData>();
            listSessions = TerminalSession.ListSessions(servername);
            //String SESSIONID = listSessions[0].ToString();
            TerminalSessionInfo terminalSessionInfo = new TerminalSessionInfo();


            string errorpath = AppDomain.CurrentDomain.BaseDirectory.ToString();
            List<string> sessionId = new List<string>();
            WTS_CLIENT_ADDRESS wTS_CLIENT_ADDRESS = new WTS_CLIENT_ADDRESS();
            foreach (TerminalSessionData tmpses in listSessions)
            {
                terminalSessionInfo = TerminalSession.GetSessionInfo(servername, tmpses.SessionId);
                wTS_CLIENT_ADDRESS = terminalSessionInfo.ClientAddress;
                if(tmpses.StationName.ToString().Contains("RDP-") && !terminalSessionInfo.UserName.Equals("") && !terminalSessionInfo.ClientName.ToString().Equals(""))
                {
                  
                    //terminalSessionInfo.ClientAddress = terminalSession.clientaddr;
                    File.AppendAllText(errorpath + "sessions.txt", "Station Name: " + terminalSessionInfo.WinStationName + " ---> Session ID: " + terminalSessionInfo.SessionId.ToString() + " Username: " + terminalSessionInfo.UserName.ToString()+" Client Name: "+terminalSessionInfo.ClientName +" Client Address: "+ BitConverter.ToString(wTS_CLIENT_ADDRESS.Address) + Environment.NewLine);
                   
                }
            }
       }
    }
}
