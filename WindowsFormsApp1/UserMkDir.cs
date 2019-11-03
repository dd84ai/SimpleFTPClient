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
        bool Linuxiod = false;
        ftp ftpClient;
        string ServerPath;
        public UserMkDir(bool Linux = false, ftp ftpClientIn = null, string ServerPathin = "")
        {
            InitializeComponent();
            Linuxiod = Linux;
            ftpClient = ftpClientIn;
            ServerPath = ServerPathin;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Linuxiod)
            {
                try
                {
                    ftpClient.createDirectory(ServerPath + "/" + textBox1.Text);
                    this.Close();
                }
                catch (Exception e55)
                {
                    MessageBox.Show("Error: " + e55.Message);
                }
            }
            else
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
