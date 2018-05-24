using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


/* 服务器端动作:绑定一个端点，然后开始监听。如果用客户端连接过来，使用Socket clientSocket = socket.Accept()
 *              生成一个完整的Socket对象，然后使用这个Socket对象与目标客户端进行通信。
 * 注意:完整的Socket(套接字)有五要素。即自己的IP和端口号，对方的IP的端口号，通信协议。
 *      如果要进行通信，则两方掌握的Socket要素要全部相同。
 */

namespace WebSever
{
    public partial class Sever : Form
    {
        public Sever()
        {
            InitializeComponent();
        }


        private Socket socket;
        private Socket clientsocket;

        private void b_startjian_Click(object sender, EventArgs e)
        {
            //获取框内Ip地址
            IPAddress localaddress = IPAddress.Parse(t_Ipdress.Text);

            //创建端点
            IPEndPoint endPoint = new IPEndPoint(localaddress,int.Parse(t_duankou.Text));

            //Ip4地址，流方式，Tcp协议
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            //绑定端点
            socket.Bind(endPoint);

            socket.Listen(10);

            Thread thread = new Thread(()=>Receive());
            thread.Start();

            if(socket.IsBound)
            {
                l_tishi.Text = "绑定成功,开始监听";
            }
            
            
        }

        private void b_send_Click_1(object sender, EventArgs e)
        {
            String message = t_send.Text;

            Byte[] buffer = new byte[1024];

            buffer = Encoding.Default.GetBytes(message);

            clientsocket.Send(buffer);

            t_send.Clear();
        }


        /// <summary>
        /// 接收函数
        /// </summary>
        private  void Receive()
        {
            while(true)
            {
                clientsocket = socket.Accept();
                //clientsocket =new Socket.Bind(socket.RemoteEndPoint);

                while (clientsocket.IsBound)
                {

                    Byte[] buffer = new Byte[1024];
                    int length = clientsocket.Receive(buffer, 1024, SocketFlags.None);
                    String xiaoxi = Encoding.Default.GetString(buffer);

                    if (length == 0)
                    {
                        clientsocket.Shutdown(SocketShutdown.Both);
                        clientsocket.Close();
                        clientsocket.Dispose();
                        break;
                    }

                    this.Invoke(new Action(() =>
                    {
                        t_texttalk.Text += (clientsocket.RemoteEndPoint);
                        t_texttalk.Text += Environment.NewLine;
                        t_texttalk.Text += xiaoxi;
                        t_texttalk.Text += Environment.NewLine;
                    })
                    );

                }
                clientsocket.Close();
            }
            
        }

        private void Sever_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((socket != null)&& (clientsocket.Connected))
            {

                clientsocket.Shutdown(SocketShutdown.Both);
                clientsocket.Close();
                socket.Close();
                
            }
            else if(socket != null)
            {
                socket.Close();
            }
        }

        private void Sever_Load(object sender, EventArgs e)
        {
            t_Ipdress.Text = "127.0.0.1";
            t_duankou.Text = "52323";
        }

        private void t_texttalk_TextChanged(object sender, EventArgs e)
        {
            t_texttalk.SelectionStart = t_texttalk.TextLength;
            t_texttalk.ScrollToCaret();
        }

        
    }
}
