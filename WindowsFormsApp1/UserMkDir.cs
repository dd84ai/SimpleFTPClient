using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class UserMkDir : Form
    {
        public UserMkDir()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.Directory.CreateDirectory(textBox1.Text);
                this.Close();
            }
            catch (Exception e55)
            {
                MessageBox.Show("Error: " + e55.Message);
            }
        }

        private void UserMkDir_Load(object sender, EventArgs e)
        {

        }

    }
}
