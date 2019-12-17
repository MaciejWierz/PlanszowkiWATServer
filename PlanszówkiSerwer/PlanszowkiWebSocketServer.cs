using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SuperSocket.SocketBase;
using SuperWebSocket;
using System.Text;
using System.Threading.Tasks;

namespace PlanszówkiSerwer
{
    public class PlanszowkiWebSocketServer
    {
        private static WebSocketServer wsServer;


        public PlanszowkiWebSocketServer()
        {
            wsServer = new WebSocketServer();
            int port = 2137;
            
            wsServer.Setup(port);
            wsServer.NewSessionConnected += WsServer_NewSesssionConnected;
            wsServer.NewMessageReceived += WsServer_NewMessageReceived;
            wsServer.NewDataReceived += WsServer_NewDataReceived;
            wsServer.SessionClosed += WsServer_SessionClosed;
            wsServer.Start();
            while (true) ;
           

        }

        private static void WsServer_SessionClosed(WebSocketSession session, CloseReason value)
        {
        }

        private static void WsServer_NewDataReceived(WebSocketSession session, byte[] value)
        {
        }

        private static void WsServer_NewMessageReceived(WebSocketSession session, string value)
        {
            session.Send("Tak jak Pan Jezus powiedział");
        }

        private static void WsServer_NewSesssionConnected(WebSocketSession session)
        {
        }

        public void stopServer()
        {
            wsServer.Stop();
        }
    }
}