using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace C_S
{
    public partial class Login : Form
    {
        HomePanel HP = new HomePanel();
        private const string serverIP = "192.168.1.3";
        private const int serverPort = 1234;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTXT.Text;
            string password = passwordTXT.Text;


            try
            {
                using (TcpClient client = new TcpClient(serverIP, serverPort))
                {
                    NetworkStream stream = client.GetStream();

                    string credentials = $"AUTH:{username}:{password}";
                    byte[] credentialsBytes = Encoding.UTF8.GetBytes(credentials);
                    byte[] lengthBytes = BitConverter.GetBytes(credentialsBytes.Length);

                    stream.Write(lengthBytes, 0, lengthBytes.Length);
                    stream.Write(credentialsBytes, 0, credentialsBytes.Length);

                    byte[] responseBytes = new byte[sizeof(int)];
                    stream.Read(responseBytes, 0, sizeof(int));
                    string response = Encoding.UTF8.GetString(responseBytes);
                    bool isAuthenticated = response == "true";

                    if (isAuthenticated)
                    {
                        MessageBox.Show("Connected successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HP.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
