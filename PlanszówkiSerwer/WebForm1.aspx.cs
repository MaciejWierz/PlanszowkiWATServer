using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlanszówkiSerwer
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        PlanszowkiWebSocketServer server;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Thread thread = new Thread(serverRun);
                thread.Start();
            }

        }


        private void serverRun()
        {
            server = new PlanszowkiWebSocketServer();
        }


    }
}