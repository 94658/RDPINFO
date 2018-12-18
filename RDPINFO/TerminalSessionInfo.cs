using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDPINFO
{
    class TerminalSessionInfo
    {
        public string InitialProgram;
        public string ApplicationName;
        public string WorkingDirectory;
        public string OEMId;
        public int SessionId;
        public string UserName;
        public string WinStationName;
        public string DomainName;
        public TerminalSession.WTS_CONNECTSTATE_CLASS ConnectState;
        public int ClientBuildNumber;
        public string ClientName;
        public string ClientDirectory;
        public int ClientProductId;
        public int ClientHardwareId;
        public TerminalSession.WTS_CLIENT_ADDRESS ClientAddress;
        public TerminalSession.WTS_CLIENT_DISPLAY ClientDisplay;
        public int ClientProtocolType;
    }
}
