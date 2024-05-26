using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace C_S
{
    public partial class Login : Form
    {
        AddProductForm ADP = new AddProductForm();
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
                // Connect to the server
                using (TcpClient client = new TcpClient(serverIP, serverPort))
                {
                    // Get the network stream
                    NetworkStream stream = client.GetStream();

                    // Convert username and password to bytes
                    byte[] usernameBytes = Encoding.UTF8.GetBytes(username);
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                    // Send username and password length first
                    stream.Write(BitConverter.GetBytes(usernameBytes.Length), 0, sizeof(int));
                    stream.Write(BitConverter.GetBytes(passwordBytes.Length), 0, sizeof(int));

                    // Send username and password
                    stream.Write(usernameBytes, 0, usernameBytes.Length);
                    stream.Write(passwordBytes, 0, passwordBytes.Length);

                    byte[] responseBytes = new byte[sizeof(bool)];
                    stream.Read(responseBytes, 0, sizeof(bool));
                    bool isAuthenticated = BitConverter.ToBoolean(responseBytes, 0);


                    if (isAuthenticated)
                    {
                        MessageBox.Show("Connected successfully", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ADP.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
