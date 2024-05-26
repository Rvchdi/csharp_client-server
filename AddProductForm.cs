using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace C_S
{
    public partial class AddProductForm : Form
    {
        private const int serverPort = 1234;
        private const string serverIp = "192.168.1.3";

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            RefreshDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add product
            string name = NameTXT.Text;
            string type = TypeTXT.Text;
            string code = CodeTXT.Text;
            int quantity = int.Parse(QuantityTXT.Text);

            string message = $"ADD:{name}:{type}:{code}:{quantity}";
            bool result = bool.Parse(SendMessageToServer(message, true));
            MessageBox.Show(result ? "Product added successfully." : "Failed to add product.");
            RefreshDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear textboxes
            NameTXT.Text = string.Empty;
            TypeTXT.Text = string.Empty;
            CodeTXT.Text = string.Empty;
            QuantityTXT.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string message = $"DELETE:{id}";
                bool result = bool.Parse(SendMessageToServer(message, true));
                MessageBox.Show(result ? "Product deleted successfully." : "Failed to delete product.");
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
            RefreshDataGrid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Delete selected product
            RefreshDataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                NameTXT.Text = row.Cells["Name"].Value.ToString();
                TypeTXT.Text = row.Cells["Type"].Value.ToString();
                CodeTXT.Text = row.Cells["Code"].Value.ToString();
                QuantityTXT.Text = row.Cells["Quantity"].Value.ToString();
            }
        }

        private void InitializeDataGridView()
        {
            // Initialize the DataGridView with the necessary columns
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns.Add("Code", "Code");
            dataGridView1.Columns.Add("Quantity", "Quantity");
        }

        private void RefreshDataGrid()
        {
            string message = "GETALL:";
            string response = SendMessageToServer(message, false);
            if (!string.IsNullOrEmpty(response))
            {
                string[] rows = response.Split('|');

                dataGridView1.Rows.Clear();
                foreach (string row in rows)
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        string[] columns = row.Split(',');
                        dataGridView1.Rows.Add(columns);
                    }
                }
            }
        }

        private string SendMessageToServer(string message, bool isBooleanResponse)
        {
            try
            {
                using (TcpClient client = new TcpClient(serverIp, serverPort))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                    byte[] lengthBytes = BitConverter.GetBytes(messageBytes.Length);
                    stream.Write(lengthBytes, 0, lengthBytes.Length);
                    stream.Write(messageBytes, 0, messageBytes.Length);

                    byte[] responseBytes = new byte[1024];
                    int bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
                    string response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

                    if (isBooleanResponse)
                    {
                        return response;
                    }
                    else
                    {
                        return response;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return isBooleanResponse ? "false" : string.Empty;
            }
        }
    }
}
