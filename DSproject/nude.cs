using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;

namespace DSproject
{
    class nude
    {
        private string allian;
        private IPAddress myIP;
        private Tuple<string, IPAddress> nudeName;  //item1=allian iteme2=myIP;
        private List<Tuple<string, IPAddress>> neighbours=
            new List<Tuple<string, IPAddress>>(); //list all neighbours
        int UPdatePort = 30000 , messagePort=50000;//get/set nudename
        StreamReader sIn;
        StreamWriter sOut;
        TcpListener updatelisiner;
        TcpListener messageLisiner;
        public nude(string allian)
        {
            this.allian = allian;
            IPAddress[] localIP = Dns.GetHostAddresses("");
            myIP = localIP[0];
            foreach(IPAddress add in localIP)
            {
                if (!IPAddress.IsLoopback(add)&&add.AddressFamily==AddressFamily.InterNetwork)
                {
                    myIP = add;
                    break;
                }
                updatelisiner = new TcpListener(myIP, UPdatePort);
                updatelisiner.Start();
                BackgroundWorker bwUpdate = new BackgroundWorker();
                bwUpdate.WorkerSupportsCancellation = true;
                bwUpdate.DoWork += new DoWorkEventHandler(this.background_update);

                messageLisiner = new TcpListener(myIP, messagePort);
                messageLisiner.Start();
                BackgroundWorker bwChat = new BackgroundWorker();
                bwChat.WorkerSupportsCancellation = true;
                bwChat.DoWork += new DoWorkEventHandler(this.background_message);

                
                
            }
            nudeName = new Tuple<string, IPAddress>(allian, myIP);
        }
        public void updateMe(IPAddress rubuIPAddress)
        {
            TcpClient me = new TcpClient(rubuIPAddress.ToString(), UPdatePort);
            me.Connect(rubuIPAddress.ToString(), UPdatePort);
            sOut = new StreamWriter(me.GetStream());
            sOut.WriteLine(nudeName.Item1);
            sOut.WriteLine(nudeName.Item2.ToString());
            sOut.Flush();
            sOut.Close();
            me.Close();

        }
        public void sendRequistToRubo()
        {
            //ask Q 
        }
        public void sendMessegToChat(string s)
        {
             
        }
        public void getMessage()
        {

        }
        public void updateIPList()
        {
            string name, sipAddres;
            IPAddress ipaddres;
            TcpClient getUpdate = updatelisiner.AcceptTcpClient();
            sIn = new StreamReader(getUpdate.GetStream());
            sIn.ReadLine();
            name = sIn.ToString();
            sIn.ReadLine();
            sipAddres = sIn.ToString();
            sIn.Close();
            ipaddres = IPAddress.Parse(sipAddres);
            Tuple  <string,IPAddress> tempt = new Tuple<string, IPAddress>(name, ipaddres);
            neighbours.Add(tempt);
                    
        }
        private void background_update (object sender ,DoWorkEventArgs e)
        {
            updateIPList();
        }
        private void background_message (object sender, DoWorkEventArgs e)
        {
            getMessage();
        }

    }
}
