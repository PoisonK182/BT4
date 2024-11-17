﻿using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;

namespace excercise_2
{
    public partial class login : Form
    {
        private Socket Client;
    public class UserInfo
    {
        public string Username { get; set; }
        public string Email { get; set; }
    }
        public static string Passdecode(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            signup log = new signup();
            log.Show();
            this.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = Passdecode(textBox2.Text);
            string ServerIp = "127.0.0.1";
            int port = 11000;

            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ServerIp), port);
            await Task.Run(() => Client.Connect(endPoint));

            var Loginpacket = new Packet("LoginRequest", "", username, "", password, "");
            string packetString = Loginpacket.ToPacketString();


            byte[] messageBytes = Encoding.UTF8.GetBytes(packetString);
            await Task.Run(() => Client.Send(messageBytes));

            await ReceiveData();

        }
        private async Task ReceiveData()
        {
            try
            {
                while (Client.Connected)
                {
                    byte[] buffer = new byte[512];
                    int bytesRead = await Task.Run(() => Client.Receive(buffer));
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Packet receivedPacket = Packet.FromPacketString(response);

                    if (receivedPacket.Request == "LoginResponse" && receivedPacket.Message == "LoginSuccessful")
                    {
                        Invoke(new Action(() =>
                        {
                            TimSach find = new TimSach(receivedPacket.Username,receivedPacket.Email);
                            find.Show();
                            this.Hide();
                        }));
                    }
                    else if (receivedPacket.Request == "LoginFailed")
                    {
                        MessageBox.Show("Thông tin đăng nhập không đúng, vui lòng nhập lại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


