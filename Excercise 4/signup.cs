﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static excercise_2.login;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace excercise_2
{
    public partial class signup : Form
    {
        private string password;
        private string email;
        private string username;
        private string name;
        private Socket Client;
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
        public static bool checkmail(string email)
        {
            string Pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, Pattern);
        }

        public signup()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            string selecteddate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            name = textBox5.Text;
            username = textBox1.Text;
            email = textBox4.Text;
            password = Passdecode(textBox2.Text);
            string confirm = Passdecode(textBox3.Text);
            string ServerIp = "127.0.0.1";
            int port = 11000;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (password.Length < 5)
            {
                MessageBox.Show("Mật Khẩu Yếu!");
                return;
            }
            if (password != confirm)
            {
                MessageBox.Show("Lỗi Mật Khẩu!");
                return;
            }
            if (!checkmail(email))
            {
                MessageBox.Show("Email không đúng định dạng , Nhập lại.");
                return;
            }
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ServerIp), port);
            await Task.Run(() => Client.Connect(endPoint));

            var Signuppacket = new Packet("SignupRequest", "", username, "", password, email);
            string packetString = Signuppacket.ToPacketString();


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

                    if (receivedPacket.Request == "SignupResponse" && receivedPacket.Message == "SignupSuccessful")
                    {
                        Invoke(new Action(() =>
                        {
                            TimSach find = new TimSach(username,email);
                            find.Show();
                            this.Hide();
                        }));
                    }
                    else if (receivedPacket.Message == "SignupFailedName")
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng nhập lại.");
                    }
                    else if (receivedPacket.Message == "SignupFailedEmail")
                    {
                        MessageBox.Show("Email đã tồn tại, vui lòng nhập lại.");
                    }
                    else if (receivedPacket.Message == "SignupFailed")
                    {
                        MessageBox.Show("Lỗi Đăng ký, vui lòng thử lại.");
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}