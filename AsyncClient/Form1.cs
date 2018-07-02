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

namespace AsyncClient
{
    public partial class Client : Form
    {
        byte[] m_dataBuffer = new byte[10];

        IAsyncResult m_result;

        public AsyncCallback m_pfnCallBack;
        public Socket m_clientSocket;

        delegate void SetTextCallBack(string text);

        private List<CommObject> ClientList = new List<CommObject>();

        /// <summary>
        /// Ctor
        /// </summary>
        public Client()
        {
            InitializeComponent();

            textBoxServerIP.Text = GetIP();

            tbPort.Text = System.Configuration.ConfigurationManager.AppSettings["ServerPort"].ToString();
        }
        /// <summary>
        /// Set the Neccessary item to GUI IP and default Port
        /// </summary>
        /// <returns></returns>
        private string GetIP()
        {
            String strHostName = Dns.GetHostName();

            // Find host by name
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

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
        /// We are done close the comm and form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttondisconn_Click(object sender, EventArgs e)
        {
           if(m_clientSocket != null)
            {
                m_clientSocket.Close();
                m_clientSocket = null;
                UpdateControls(false);
            }
            
        }
        /// <summary>
        /// Update state of the Forms Object 
        /// </summary>
        /// <param name="connected"></param>
        private void UpdateControls(bool connected)
        {
            buttonConn.Enabled = !connected;
            buttondisconn.Enabled = connected;
            string connectStatus = connected ? "Connected" : "Not Connected";
            labelState.Text =  connectStatus;
        }
        /// <summary>
        /// COnnect to the Server 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConn_Click(object sender, EventArgs e)
        {
            // See if Ip and Port are Filled 

            if(textBoxServerIP.Text == "" || tbPort.Text == "")
            {
                MessageBox.Show("IP Address and Port Number are required to connect to the Server\n");
                return;
            }

            try
            {
                UpdateControls(false);

                // create the socket instance

                m_clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Get the remote IP Address

                IPAddress iP = IPAddress.Parse(textBoxServerIP.Text);

                int iPortNo = System.Convert.ToInt16(tbPort.Text);
                // create the endpoint 
                IPEndPoint ipEnd = new IPEndPoint(iP, iPortNo);
                // connect to the remote host 

                m_clientSocket.Connect(ipEnd);

                if (m_clientSocket.Connected)
                {
                    UpdateControls(true);

                    // wait for data asynchronously

                    WaitForData();
                }

            }
            catch (SocketException se)
            {

                string str;
                str = "\nConnection failed, is the server running?\n" + se.Message;
                MessageBox.Show(str);
                UpdateControls(false);
            }
        }
        /// <summary>
        ///  Waiting for the data after connection
        /// </summary>
        private void WaitForData()
        {
            try
            {

                if(m_pfnCallBack == null)
                {
                    m_pfnCallBack = new AsyncCallback(OnDataReceived);
                }

                CommObject thesocketpkt = new CommObject();

                thesocketpkt.m_WorkScoket = m_clientSocket;

                // start listening to data asynchronously

                m_result = m_clientSocket.BeginReceive(thesocketpkt.buffer,
                                                       0, thesocketpkt.buffer.Length,
                                                       SocketFlags.None,
                                                       m_pfnCallBack,
                                                       thesocketpkt);
            }
            catch (SocketException se)
            {

                MessageBox.Show(se.Message);
            }
        }
        /// <summary>
        /// Call back calling upon recieving the data from the client 
        /// </summary>
        /// <param name="asyn"></param>
        private void OnDataReceived(IAsyncResult asyn)
        {
            try
            {
                CommObject theSocketId = (CommObject)asyn.AsyncState;

                int iRx = theSocketId.m_WorkScoket.EndReceive(asyn);

                char[] chars = new char[iRx + 1];

                System.Text.Decoder d = Encoding.UTF8.GetDecoder();

                int charLength = d.GetChars(theSocketId.buffer, 0, iRx, chars, 0);

                string szData = new string(chars);

                SetRcvText(szData);
                // rTbrcvmsg.Text = rTbrcvmsg.Text + szData;

                WaitForData();
            }
            catch (ObjectDisposedException)
            {

                System.Diagnostics.Debugger.Log(0, "1", "\nOnDataReceived: Socket has been closed\n");
            }
            catch(SocketException se)
            {
                MessageBox.Show(se.Message);
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
            if (this.rTbrcvmsg.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(SetRcvText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rTbrcvmsg.Items.Add(text);
            }
        }
        /// <summary>
        /// Send Message to the conneted Client 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSendmsg_Click(object sender, EventArgs e)
        {
            try
            {
                object objData = richTextBoxmsg.Text;

                byte[] byData = System.Text.Encoding.ASCII.GetBytes(objData.ToString());

                if(m_clientSocket != null)
                {
                    m_clientSocket.Send(byData);
                }
            }
            catch (SocketException se)
            {

                MessageBox.Show(se.Message);
            }
        }
        /// <summary>
        /// Release the Socket in Use and Close the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btclose_Click(object sender, EventArgs e)
        {
            if (m_clientSocket != null)
            {
                m_clientSocket.Close();
                m_clientSocket = null;
            }

            Close();
        }
    }
}
