using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncServer
{
    public partial class Server : Form
    {
       
        private List<CommObject> ClientLists = new List<CommObject>();

        const int MAX_CLIENTS = 10;

        public AsyncCallback pfnWorkerCallBack;
        private Socket m_mainSocket;
        private Socket[] m_workerSocket = new Socket[10];
        private int m_clientCount = 0;


        /** Logger */
        private LogManager Logger;
        delegate void SetTextCallBack(string text);
        /// <summary>
        /// ctor
        /// </summary>
        public Server()
        {
            InitializeComponent();
            Logger = new LogManager(false);
            textBoxIP.Text = getIP();

            textBoxPort.Text = System.Configuration.ConfigurationManager.AppSettings["ServerPort"].ToString();

            btStart.BackColor = Color.Green;

            Logger.Trace("Initialize.......");
        }
        /// <summary>
        /// Set the parameter to the GUI
        /// </summary>
        /// <returns></returns>
        private string getIP()
        {
            String strHostName = Dns.GetHostName();

            // Find host by name
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);                      // Dns.GetHostEntry(strHostName);

            // Grab the first IP addresses
            String IPStr = "";
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                IPStr = ipaddress.ToString();
                return IPStr;
            }
            return IPStr;
        }

        
        /// <summary>
        /// ShutDown Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClose_Click(object sender, EventArgs e)
        {

            CloseSockets();
            UpdateControls(false);
            btStart.BackColor = Color.Silver;
        }
        /// <summary>
        ///  Close all open ports and free all the clients
        /// </summary>
        private void CloseSockets()
        {
            if (m_mainSocket != null)
            {
                m_mainSocket.Close();
            }
            for (int i = 0; i < m_clientCount; i++)
            {
                if (m_workerSocket[i] != null)
                {
                    m_workerSocket[i].Close();
                    m_workerSocket[i] = null;
                }
            }
        }

        /// <summary>
        /// Start Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btStart_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxPort.Text == "")
                {
                    MessageBox.Show("Please Enter A Port");
                    return;
                }
                btClose.BackColor = Color.Red;
                int port = System.Convert.ToInt32(textBoxPort.Text.ToString());

                // Create the listening socket ....

                m_mainSocket = new Socket(AddressFamily.InterNetwork, 
                                          SocketType.Stream, 
                                          ProtocolType.Tcp);

                IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, port);

                // Bind to local IP Adress..

                m_mainSocket.Bind(ipLocal);

                // Start Listening ...

                m_mainSocket.Listen(4);

                
                // create the call back for any client connections....

                m_mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);

                string str = string.Format("Sever started Listening on port {0} \n ", port);
                rtbRcvMessage.Items.Add(str);
                UpdateControls(true);
            }
            catch (SocketException se)
            {

                MessageBox.Show(se.Message);
            }
        }
        /// <summary>
        /// Return to ui Thread
        /// </summary>
        /// <param name="text"></param>
        private void SetSatusText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tbstatus.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(SetSatusText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tbstatus.Text = text;
            }
        }

        /// <summary>
        /// Return to ui Thread
        /// </summary>
        /// <param name="text"></param>
        private void SetRcvText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.rtbRcvMessage.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(SetRcvText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rtbRcvMessage.Items.Add(text);
            }
        }
        /// <summary>
        /// Callback call after client is conneted to server
        /// </summary>
        /// <param name="asyn"></param>
        private void OnClientConnect(IAsyncResult asyn)
        {
            try
            {
                // Here we complete/end the BeginAccept() asynchronous call
                // by calling EndAccept() - which returns the reference to
                // a new Socket object

                m_workerSocket[m_clientCount] = m_mainSocket.EndAccept(asyn);

                // Let the worker Socket do the further processing for the 
                // just connected client

                WaitForData(m_workerSocket[m_clientCount]);
                // Now Increment the client count 

                ++m_clientCount;

                //Display this client connection as a status message on the GUI
                string str = string.Format("Client # {0} is connected ", m_clientCount);
                Logger.Trace(str);
                // tbstatus.Text = str;
                // @ https://stackoverflow.com/questions/10775367/cross-thread-operation-not-valid-control-textbox1-accessed-from-a-thread-othe
                SetSatusText(str);


                // Since the main Socket is now free it can go back and wait for other clinets who are atttempting to connect 

                m_mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);

               
            }
            catch (ObjectDisposedException)
            {

                System.Diagnostics.Debugger.Log(0, "1", "\n OnClientConnection Socket Has been closed \n");
            }
            catch(SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        /// <summary>
        /// Waiting for the data from server 
        /// </summary>
        /// <param name="Soc"></param>
        private void WaitForData(Socket Soc)
        {
            try
            {
                if(pfnWorkerCallBack == null)
                {
                    // Specify the call back function which is to be 
                    // invoked when there is any write activity by the 
                    // connected client

                    pfnWorkerCallBack = new AsyncCallback(OnDataReceived);
                }

                CommObject theSocketPckt = new CommObject();

                theSocketPckt.m_CurrentSocket = Soc;

                // Start receiving any data written by the connected client asynchronously

                Soc.BeginReceive(theSocketPckt.dataBuffer, 
                                 0, theSocketPckt.dataBuffer.Length, 
                                 SocketFlags.None, 
                                 pfnWorkerCallBack, 
                                 theSocketPckt);
            }
            catch (SocketException se)
            {

                MessageBox.Show(se.Message);
            }
        }
        /// <summary>
        ///  This the call back function which will be invoked when the socket
        ///  detects any client writing of data on the stream
        /// </summary>
        /// <param name="asyn"></param>
        private void OnDataReceived(IAsyncResult asyn)
        {
            try
            {
                CommObject SocketData = (CommObject)asyn.AsyncState;

                int iRx = 0;

                // Complete the BeginReceive() asynchronous call by EndReceive() method
                // which will return the number of characters written to the stream 
                // by the client

                iRx = SocketData.m_CurrentSocket.EndReceive(asyn);
                char[] chars = new char[iRx + 1];

                // Decoder d = Encoding.UTF8.GetDecoder();
                Decoder d = Encoding.ASCII.GetDecoder();

                int charLen = d.GetChars(SocketData.
                                         dataBuffer, 
                                         0, 
                                         iRx, 
                                         chars, 
                                         0);

                string szData = new string(chars);

                // There  might be more data, so store the data received so far.
                SocketData.sb.Append(Encoding.UTF8.GetString(
                    SocketData.dataBuffer, 0, iRx));

                string textq = SocketData.sb.ToString().Trim('\0');
                Logger.Info(textq);
                string text = System.Text.Encoding.ASCII.GetString(SocketData.dataBuffer);
                Logger.Info(textq);
                //rtbRcvMessage.Text = rtbRcvMessage.Text + szData;

                byte[] bytes = Encoding.ASCII.GetBytes(textq);

                char[] charsm = Encoding.ASCII.GetChars(bytes);
                Logger.Info(charsm.ToString());

                SetRcvText(szData +"\n");


                // Continue the waiting for data on the socket

                WaitForData(SocketData.m_CurrentSocket);


            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1", "\nOnDataReceived: Socket has been closed\n");
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        /// <summary>
        /// Update the GUI status 
        /// </summary>
        /// <param name="listening"></param>
        private void UpdateControls(bool listening)
        {
            btStart.ForeColor = Color.Green;
            btStart.Enabled = !listening;
            btStart.ForeColor = Color.Red;
            btClose.Enabled = listening;
        }
        /// <summary>
        /// Send the message to the Server 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                Object objData = richTextBoxSendMsg.Text;
                byte[] byData = Encoding.ASCII.GetBytes(objData.ToString());
                for (int i = 0; i < m_clientCount; i++)
                {
                    if (m_workerSocket[i] != null)
                    {
                        if (m_workerSocket[i].Connected)
                        {
                            m_workerSocket[i].Send(byData);
                        }
                    }
                }

            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        /// <summary>
        /// We are done clean everthing and close the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btcloseform_Click(object sender, EventArgs e)
        {
            CloseSockets();
            Close();
        }
    }
}
