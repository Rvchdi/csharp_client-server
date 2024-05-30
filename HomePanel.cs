using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_S
{
    public partial class HomePanel : Form
    {
        public HomePanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAddProductForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void ShowAddProductForm()
        {
            panel.Controls.Clear();
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.TopLevel = false;
            addProductForm.Parent = panel;
            addProductForm.Dock = DockStyle.Fill;
            panel.Controls.Add(addProductForm);
            addProductForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {
            ShowAddProductForm();
        }
    }
}
