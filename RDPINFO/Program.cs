using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RDPINFO.TerminalSession;

namespace RDPINFO
{
    class Program
    {
        static void Main(string[] args)
        {
           int SessionId;
            string servername= "WIN-9QFTBSN6NR3";
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
                if(tmpses.StationName.ToString().Contains("RDP-"))
                {

                    terminalSessionInfo= TerminalSession.GetSessionInfo(servername, tmpses.SessionId);
                    wTS_CLIENT_ADDRESS = terminalSessionInfo.ClientAddress;
                    //terminalSessionInfo.ClientAddress = terminalSession.clientaddr;
                    File.AppendAllText(errorpath + "sessions.txt", "Station Name: " + tmpses.StationName.ToString() + " ---> Session ID: " + tmpses.SessionId.ToString() + " Username: " + terminalSessionInfo.UserName.ToString()+ "Client Address: "+ BitConverter.ToString(wTS_CLIENT_ADDRESS.Address) + Environment.NewLine);
                   
                }
                    
                
             
            }


            //SessionId=Int32.Parse(tmpses.SessionId.ToString());
            //terminalSessionInfo = TerminalSession.GetSessionInfo(servername, SessionId);
            //

            //foreach (string session in sessionId)
            //{

            //        SessionId = Int32.Parse(session);
            //        terminalSessionInfo = TerminalSession.GetSessionInfo(servername, SessionId);
            //        File.AppendAllText(errorpath + "sessions.txt", session);



            //}
        }
    }
}
