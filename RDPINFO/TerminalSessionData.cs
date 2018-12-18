using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDPINFO
{
    class TerminalSessionData
    {
        public int SessionId;
        public TerminalSession.WTS_CONNECTSTATE_CLASS ConnectionState;
        public string StationName;

        public TerminalSessionData(int sessionId, TerminalSession.WTS_CONNECTSTATE_CLASS connState, string stationName)
        {
            SessionId = sessionId;
            ConnectionState = connState;
            StationName = stationName;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", SessionId, ConnectionState, StationName);
        }
    }
}
