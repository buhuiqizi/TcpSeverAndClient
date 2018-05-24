using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


/* 客户端动作:连接目标服务端的IP，然后组成完整Socket。用这个Socket与服务端进行通信。
 * 注意:完整的Socket(套接字)有五要素。即自己的IP和端口号，对方的IP的端口号，通信协议。
 *      如果要进行通信，则两方掌握的Socket要素要全部相同。
 * 因为客户端没用使用bind函数，所以在Connet的时候，系统会分配一个没用冲突的端点给它。
 * 但是客户端也可以使用bind函数来手动分配一个端点。
 * 即实现TCP通信，客户端与服务端都要有自己的端点和目标的端点。只不过服务端常常使用bind
 * 来人为指定，而客户端一般由系统分配。造成了客户端只有一步而服务端有两步的假象。
 */

namespace WebClient
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private Socket socket;

        private void b_startjian_Click(object sender, EventArgs e)
        {
            //获取框内Ip地址
            IPAddress localaddress = IPAddress.Parse(t_Ipdress.Text);

            //创建端点
            IPEndPoint endPoint = new IPEndPoint(localaddress, int.Parse(t_duankou.Text));

            //Ip4地址，流方式，Tcp协议
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            //连接端点
            socket.Connect(endPoint);

            Thread thread = new Thread(() => Receive());
            thread.Start();

            if(socket!=null)
            {
                l_tishi.Text = "连接成功";
            }
            
        }

 
        private void b_send_Click(object sender, EventArgs e)
        {
            String message = t_send.Text;

            Byte[] buffer = new byte[1024];

            buffer = Encoding.Default.GetBytes(message);

            socket.Send(buffer);

            t_send.Clear();
        }


        /// <summary>
        /// 接收函数
        /// </summary>
        /// <param name="null">其实这个函数没有参数</param>
        /// <returns>
        /// 什么也不返回
        /// </returns>
        private void Receive()
        {

            int a = 0;

            while (socket.IsBound)
            {

                Byte[] buffer = new Byte[1024];
                int length = socket.Receive(buffer, 1024, SocketFlags.None);
                String xiaoxi = Encoding.Default.GetString(buffer);

                this.Invoke(new Action(() =>
                {
                    t_texttalk.Text += (socket.RemoteEndPoint);
                    t_texttalk.Text += Environment.NewLine;
                    t_texttalk.Text += xiaoxi;
                    t_texttalk.Text += Environment.NewLine;
                })
                );
            }
            socket.Close();
        }


        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(socket!=null)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            
        }

        private void Client_Load(object sender, EventArgs e)
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
