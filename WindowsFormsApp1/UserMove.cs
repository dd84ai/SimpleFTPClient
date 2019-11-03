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
    public partial class UserMove : Form
    {
        string Main = "";
        bool Linuxiod = false;
        ftp ftpClient;
        string ServerPath;
        public UserMove(string Starter, bool Linux = false, ftp ftpClientIn = null, string ServerPathIn = "")
        {
            InitializeComponent();
            textBox1.Text = Starter;
            Main = Starter;
            Linuxiod = Linux;
            ftpClient = ftpClientIn;
            ServerPath = ServerPathIn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Linuxiod)
            {
                try
                {
                    ftpClient.rename(ServerPath + "/" + Main, textBox1.Text);
                }
                catch (Exception Err)
                {
                    MessageBox.Show(Err.Message);
                }
            }
            else
            {
                string Adress = Directory.GetCurrentDirectory() + "\\" + Main.Replace("\\", "");
                if (Main.Contains("\\"))
                    try
                    {
                        Directory.Move(Adress, Directory.GetCurrentDirectory() + "\\" + textBox1.Text.Replace("\\", ""));
                    }
                    catch (Exception Err)
                    {
                        MessageBox.Show(Err.Message);
                    }
                else
                    try
                    {
                        File.Move(Adress, Directory.GetCurrentDirectory() + "\\" + textBox1.Text.Replace("\\", ""));
                    }
                    catch (Exception Err)
                    {
                        MessageBox.Show(Err.Message);
                    }
            }
            this.Close();

        }
    }
}
